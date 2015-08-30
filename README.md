BarcodeImageGenerationLibrary.Net
=================================

Generate Barcode Images for .NET.

Forked from Brad Barnhill's Barcode Image Generation Library over on Code Project.
https://workspaces.codeproject.com/bradbarnhill/barcode-image-generation-library

Following is derived from original Code Project repo:

![Screenshot of the Demo application](https://raw.githubusercontent.com/Spitfire1900/BarcodeImageGenerationLibrary.Net/master/BarcodeDemo/screenshot.jpg)
Introduction
----

This article and its code provides a way for developers to put barcodes into their applications. It allows for the generation of barcode images without the use of "barcode fonts". This need arose out of the necessity for one of my own projects to use barcodes and the lack of free libraries on the web to do the job.

To give an idea of what happens in this library: it first turns the data into a series of 1s and 0s representing equal-width bars and spaces. This string of binary information is then sent to a drawing function that converts it to an image representing the desired barcode. This approach allows for one common drawing method to be used on all symbologies.

Supported Encoding Types
----

  |   |   |
----- | ----- | -----
Code 128 | Code11 | Code 39 (Extended / Full ASCII)
Code 93 | EAN-8 | EAN-13
UPC-A | UPC-E 	JAN-13
MSI | ISBN | Standard 2 of 5
Interleaved 2 of 5 | PostNet | UPC Supplemental 2
UPC Supplemental 5 | Codabar |	ITF-14
Telepen | Pharmacode |	FIM (Facing Identification Mark)

** Keep in mind that some symbologies go by more than one name, so make sure the one you are using isn't listed above by a different name before contacting me to add it. If it isn't listed above and you would like me to look at adding it to this library, please submit a pull request. (Bugs are always a priority, so please send those.)

Using the Code
----

The library contains a class called BarcodeLib. There are three constructors:

```
Barcode();
Barcode(string);
Barcode (string, BarcodeLib.TYPE);
```

If you decide to create an instance with parameters, the parameters are as follows: the string is the data to be encoded into the barcode, and BarcodeLib.TYPE is the symbology to encode the data with. If you do not choose to specify the data and type at the time the instance is created, you may specify them through the appropriate property later on (but before you encode).

```
BarCodeLib.Barcode b = new BarCodeLib.Barcode(BarCodeLib.TYPE.UPCA, 
          "038000356216", Color.Black, Color.White, 300, 150);
```

To get the image representing the data generated, you must then call one of the many Encode functions.

```
public Image Encode(TYPE iType, string StringToEncode, int Width, int Height)
public Image Encode(TYPE iType, string StringToEncode, 
        Color ForeColor, Color BackColor, int Width, int Height)
public Image Encode(TYPE iType, string StringToEncode, Color ForeColor, Color BackColor)
public Image Encode(TYPE iType, string StringToEncode)
Encode(TYPE iType)
Encode()
```

The resulting Image contains the barcode in image format. More functionality has been added, so you can save the Image once it is encoded.

```
public void SaveImage(string Filename, SaveTypes FileType)
```

This function can be used by specifying the full path (filename included) of the location you would like to save the image to as a string. The second parameter is an enumerator (BarcodeLib.SaveTypes) that represents the supported types (JPG, BMP, PNG, GIF, TIFF) of files you can save. Functionality has been added so that you can now set the IncludeLabel parameter to allow it to draw the data that's encoded in the barcode, below the image, as a label. Keep in mind that this will take up some of the space you specify for the size of the image.

```
b.IncludeLabel = true;
```
This is used to put the data encoded at the bottom of the image. If you do not set this parameter, it will just generate the barcode without the data at the bottom.
