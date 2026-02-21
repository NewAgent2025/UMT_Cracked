# UMT_Cracked (Universal Minecraft Tool)

## Overview

**UMT_Cracked** is a modified version of the Universal Minecraft Tool designed to allow access to the software without requiring a paid license.
The original application is not free to use, and this project was created to provide an alternative method for people who cannot afford the software or who simply want to test its functionality before purchasing.

This repository contains the required files and supporting components that allow the program to run without triggering license or account validation errors.

---

## How It Works

### 1. Authentication Bypass

* The `sign-in.php` file simulates a **successful login request** to the software.
* It returns a response that makes the application believe:

  * The account exists
  * The login credentials are valid
  * The software license is active
* This prevents login errors even when using **non-existent email/username and password combinations**.

### 2. Session Validation

* The `timeCheck.php` script loads data from the `timeCheckRes` file.
* This ensures:

  * No session expiration warnings
  * No invalid session popups
  * When attempting to convert, edit, or use the program’s features, it would not load correctly and would crash.

Without this component, the application would display **errors during authentication**.

### 3. Extension & Server Data

* The `extensionDoc` file is a **ZIP archive** containing a GitHub link used for:

  * Data verification
  * Server-side reference checks
  * This also contains the files, including images and other data for worlds players and tag editing images.
  * This file is **not strictly required** for functionality, but is included for completeness.

### 4. Logout Handling

* The `sign-out.php` file enables:

  * Proper logout behavior
  * No crashes or stuck sessions when exiting the account

---

## Chunk Loading & Conversion Fix

If the software is launched without modification USING the custom ui/overlay then the:

* **Chunks will not load**
* **World conversion will fail**
* **Editor and pruning tools will not function**

This happens because the original program depends on:

`
Data from the official server or domain name is handled by updateActivityLog.php and timeCheck.php
`

which checks for the presence and validity of:

`
UMT_STREAM_ENDED and its AES encryption/decryption mechanisms, along with block processing and several additional components that were added to the system.
`

### So It Was Decided

To restore full functionality, an additional program or supporting software may be required. When using the UI overlay in this custom program, the following factors are taken into account:

* A **compatibility layer** is added on top of the cracked software.
* This secondary layer:

  * Loads chunk data normally
  * Enables world conversion between platforms
  * Restores editor and pruning features
  * Mimics the behavior of the original licensed environment

From the application’s perspective, everything appears **fully legitimate and operational**.

---

## Version Handling

* The `version.php` file is **not technically required**.
* It only exists so the software:

  * Reports the expected version number
  * Avoids update or mismatch warnings

**Important:**
Do **not update** the program if it says there is an update, or the bypass will stop working.

**I WILL FIX THIS IN A LATER UPDATE**

---

## Purpose of This Project

This project was created to:

* Help users who **cannot afford** the original software
* Allow people to **test features before buying**
* Provide an **educational example** of how request validation systems function

---

## Disclaimer

This repository is provided for **educational and research purposes only**.

* No ownership of the original software is claimed.
* Users are responsible for how they use the contents of this repository.
* Supporting the original developers by purchasing legitimate software is always recommended if you are able to do so.
