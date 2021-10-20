# Password Manager

## Model

A list of Entries that contain

* Entry name (`string`)
* Login (`string`)
* Password (`string`) - hashed / encrypted

## Storage

* Local JSON file.

* Passwords are encrypted.

* Key for encryption - passed as an argument to the core service, takes from a safe place??

## Functionality

* Starts with a prompt to start entering the name of an existing or new Entry

* Upon entering the beginning of the Entry name, searches for entries starting with it (case-insensitive) and offers a list of existing items + a list item to create a new Entry

* User selects the item from the offered list (a number?)

  * Number is not in the list - repeat and say "there is not such item"

  * Existing entry selected - say that user selected the entry with name and copy to clipboard

  * New entry selected

    * Ask for the name prefilling with the initially enetered beginning of the name

    * Ask for login

    * Ask for password (characters are displayed as "*")

    * Ask to repeat the password

* At any state, the app should be exiteable with a hotkey (e.g. "q")

* Colors
