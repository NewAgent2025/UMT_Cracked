<?php
header("Content-Type: application/json");

echo json_encode([
    "message" => "Version grabbed.",
    "status" => true,
    "version" => "1.4.47"
]);
