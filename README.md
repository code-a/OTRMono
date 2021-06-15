# OTRMono

**This repository is archived and not maintained.**

**If you are looking for a modern alternative to OTRv3 I recommend [X3DH](https://www.signal.org/docs/specifications/x3dh/) with [Double Ratchet](https://www.signal.org/docs/specifications/doubleratchet/) for the post key-agreement message encryption.**

## Description
This project is a mono library for OTR encryption with support for OTR versions 1, 2 & 3.

It is a fork of the original OTRLibMono created by Don Fizachi and released under the The Code Project Open License (CPOL).

## Why a fork?

The original library is **not**: 

  * cross platform compatible
  * compatible with newer versions of MonoDevelop
  * maintained any more...


## Install

### Installing via NuGet (recommended)

In Visual Studio's [Package Manager Console](http://docs.nuget.org/docs/start-here/using-the-package-manager-console),
simply enter the following command:

	Install-Package OTRMono

### Installing manually
  * Clone the repository
  * Open src/OTRLibMono.sln with MonoDevelop
  * Build the solution
  * Add the created DLL to your Mono-project


## Usage
At the moment, there are no examples in this repository. I might add examples for the usage of the library in the future.

**An easy to read introduction by Don Fizachi can be found at [OTR-Security-Protocol](http://www.codeproject.com/Articles/644318/Off-The-Record-OTR-Security-Protocol).**

