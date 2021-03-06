# Better GUID Generator

## Copies a random GUID to the clipboard in several formats.

- Value Only: `20296BA3-5BF4-413C-956D-68F9F83260E3`
- With Brakets: `{20296BA3-5BF4-413C-956D-68F9F83260E3}`
- Guid.Parse (c#): `var guid = Guid.Parse("20296BA3-5BF4-413C-956D-68F9F83260E3");`
- Empty: `00000000-0000-0000-0000-000000000000`

The clipboard is automatically updated when a new GUID is generated and each format selection.

![Better GUID](https://raw.githubusercontent.com/CJPrindle/BetterGuid/master/BetterGuid.png "Better GUID")

___

## Add to Visual Studio Tools Menu

The GUID generator in Visual Studio is a bit outdated. Use Better GUID instead!

*How To*
1. Select the _Tools_ menu
2. Select _External Tools_
3. Click _Add_
4. Title: _&Better GUID_
5. Command: Enter the path to BetterGUID.exe
6. Click _OK_

Better GUID will now be an option under the Tools menu (shortcut key: B).
