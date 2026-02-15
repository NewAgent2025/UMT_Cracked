<?php
// Show errors while testing (remove in production)
error_reporting(E_ALL);
ini_set('display_errors', 1);

// Set JSON header
header('Content-Type: application/json');

// Read the request JSON
$raw = file_get_contents("php://input");
$data = json_decode($raw, true);

// Validate input
if (!is_array($data) || !isset($data["sessionToken"])) {
    echo json_encode([
        "status" => false,
        "message" => "Invalid request"
    ]);
    exit;
}

// Check if session file exists
if (!file_exists("session.json")) {
    echo json_encode([
        "status" => false,
        "message" => "No active session"
    ]);
    exit;
}

// Load session
$session = json_decode(file_get_contents("session.json"), true);

// Validate token
if ($data["sessionToken"] !== $session["sessionToken"]) {
    echo json_encode([
        "status" => false,
        "message" => "Invalid session token"
    ]);
    exit;
}

// Optional: check for session expiry (1 hour example)
if ((time() - $session["time"]) > 3600) {
    unlink("session.json"); // remove expired session
    echo json_encode([
        "status" => false,
        "message" => "Session expired"
    ]);
    exit;
}

// ✅ Instead of building JSON here, read from file `timeCheckRes`
if (!file_exists("timeCheckRes")) {
    echo json_encode([
        "status" => false,
        "message" => "timeCheckRes file missing"
    ]);
    exit;
}

// Read the response file and output
$response = file_get_contents("timeCheckRes");

// Ensure no extra output
$response = trim($response);

// Output
echo $response;
exit;
