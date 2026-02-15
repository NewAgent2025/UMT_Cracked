<?php
// Enable errors only during testing; remove in production
error_reporting(E_ALL);
ini_set('display_errors', 1);

// Set JSON header
header("Content-Type: application/json");

// Read JSON input
$input = file_get_contents("php://input");
$data = json_decode($input, true);

if (!$data) {
    echo json_encode([
        "status" => false,
        "message" => "Invalid JSON"
    ]);
    exit;
}

// Get entered values safely
$username = $data["email"] ?? "UNKNOWN";

// Generate UUID v4
function generateUUIDv4() {
    $data = random_bytes(16);
    $data[6] = chr((ord($data[6]) & 0x0f) | 0x40);
    $data[8] = chr((ord($data[8]) & 0x3f) | 0x80);
    return vsprintf('%s%s-%s-%s-%s-%s%s%s', str_split(bin2hex($data), 4));
}

// Create response first
$response = [
    "message" => "Successfully Cracked!!",
    "offerCode" => false,
    "paidUser" => true,
    "saveCookie" => true,
//    "sessionToken" => generateUUIDv4(),
    "sessionToken" => "99ea8156-3cf6-458c-9e6d-33615dde60b7",
    "status" => true,
    "username" => $username
];

// Save session info safely
file_put_contents(
    "session.json",
    json_encode([
        "sessionToken" => $response["sessionToken"],
        "localSessionNum" => $data["localSessionNum"] ?? 0,
        "time" => time()
    ])
);

// Output JSON last
echo json_encode($response, JSON_PRETTY_PRINT);
exit;
