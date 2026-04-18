<?php
header("Content-Type: application/json");

// URL to the TXT file
$url = "https://raw.githubusercontent.com/NewAgent2025/UMT_Cracked/refs/heads/main/UMT_Overlay_C_Sharp/Version_Number.txt";

// Get the version text
$version = @file_get_contents($url);

// Fallback if it fails
if ($version === false) {
    $version = "1.4.47";
}

// Clean it (remove extra whitespace/newlines)
$version = trim($version);

echo json_encode([
    "message" => "Version grabbed.",
    "status" => true,
    "version" => $version
]);
