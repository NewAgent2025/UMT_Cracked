package.path = BASE_PATH .. "/?.lua;" .. package.path

extensions = {}
recursiveExtensions = {}

function RegisterExtensions(extensionsList)

    if(extensionsList:len() == 0) then return end

    local mindex = 1
    local rindex = 1

    for e in extensionsList:gmatch("([^,]*),?") do 
        e = e:gsub("^%s*(.-)%s*$", "%1")

        local extension = require(e .. "/main")

        for k, sub_e in pairs(extension) do
            if(sub_e.type ~= nil and sub_e.type == EXTENSION_TYPE.NBT_EDITOR_STYLE) then
                extensions[mindex] = sub_e
                mindex = mindex + 1

                if(sub_e.recursive) then
                    recursiveExtensions[rindex] = sub_e
                    rindex = rindex + 1
                end
            end
            
        end
    end
end

function RunExtensions(root, context)
    
    for k, sub_e in ipairs (extensions) do
        sub_e:main(root, context)
    end

    RunRecursiveExtensions(root, root, context)
end

function RunRecursiveExtensions(root, current, context)

    for k, sub_e in ipairs (recursiveExtensions) do

        --[[ experimental extension filters
        --has a file filter
        if(recursiveExtensions[k].fileFilter ~= false) then
            local filterPassed = false
            for i, fileType in ipairs(recursiveExtensions[k].recursion.fileFilter) do
                if((context.type & fileType) ~= 0) then
                    filterPassed = true
                    break
                end
            end
            if(not filterPassed) then goto extensionContinue end
        end

        --has a tag filter
        if(recursiveExtensions[k].tagFilter ~= false) then
            local filterPassed = false
            for i, tagType in ipairs(recursiveExtensions[k].recursion.tagFilter) do

                if(current.type == tagType) then
                    filterPassed = true
                    break
                end
            end
            if(not filterPassed) then goto extensionContinue end
        end
        --]]

        sub_e:recursion(root, current, context)

        --::extensionContinue::
    end

    if(current.type == TYPE.COMPOUND or current.type == TYPE.LIST) then
        for i=0, current.childCount-1 do
            RunRecursiveExtensions(root, current:child(i), context)
        end
    end
end