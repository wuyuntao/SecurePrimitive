# SecurePrimitive

**SecurePrimitive** provides several secure version of primitive data types which encrypts values when storing in memory and decrypts when accessing.

The main purpose is to prevent important variables from being changed by memory editors in game client. And of course, these data types are Unity3d compatible.

Currently, following data are included:

`SPByte` -> `byte`

`SPSByte` -> `sbyte`

`SPInt16` -> `short`

`SPUInt16` -> `ushort`

`SPInt32` -> `int`

`SPUInt32` -> `uint`

`SPInt64` -> `long`

`SPUInt64` -> `ulong`

## Usage

Here is an example for creating, getting and setting a SPInt32 variable.

```c#
using SecurePrimitive;

...

// Create SPInt32 variables with constructor
var spint0 = new SPInt32( 10 );
var spint1 = new SPInt32();     // Same as new SPInt32( 0 )

// Or create via implicit type casting
SPInt32 spint1 = 10;

// Get real value of SPInt32 variables
var int0 = spint0.Value;

// Or get real value via implicit type casting
int int1 = spint1;

```
