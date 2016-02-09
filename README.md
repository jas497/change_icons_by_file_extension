# Usage of refresh_shell32_icon_cache.exe

This guide will use $EXT to mean the file extension (without the dot).

1. Associate a default program with the file extension (Right mouse -> Open with -> Always use).
2. Run regedit (Windows key+R, then type regedit and press Return/Enter).
3. Go to `[HKEY_CLASSES_ROOT\.$EXT]`.
4. Observe the (Default) data.  This is a pointer to the key from which Explorer reads the important information.  It is usually "$EXT_auto_file", but not always.
5. Make a new key named "DefaultIcon" under the observed key, and set its (Default) value to the full path to the new icon.  In other words, do this:
    ```
    [HKEY_CLASSES_ROOT\<observed key (e.g., "java_auto_file")>\DefaultIcon]
    C:\full\path\to\icon.ico
    ```
6. Run `refresh_shell32_icon_cache.exe` (double-click works).

Path to icon can also reference icons stored inside *.exe, *.dll, etc.

Source: https://msdn.microsoft.com/en-us/library/windows/desktop/hh127427%28v=vs.85%29.aspx
