<?php
// Show errors while testing (remove in production)
error_reporting(E_ALL);
ini_set('display_errors', 1);

// Start session if it exists
if (session_status() === PHP_SESSION_NONE) {
    session_start();
}

// Destroy session data
session_unset();
session_destroy();

// Set JSON header
header('Content-Type: application/json');

// Response
$response = [
    "message" => "Signed Out Cracked Account.",
    "status" => true
];

// Output JSON
echo json_encode($response, JSON_PRETTY_PRINT);
