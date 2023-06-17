# Stegosaurus Project

This project is part of the 'CUI-Fundamental-Programming' course. The task was to create a program that can perform steganography on bitmap images. Steganography is the practice of concealing a file, message, image, or video within another file, message, image, or video. In this case, the program is designed to hide a secret message within a bitmap image.

The program is written in C# and is object-oriented. It consists of several classes, including `BinaryDataParser`, `BitmapHeader`, `BitmapInfoHeader`, and `Stegosaurus`. The `Stegosaurus` class is the main class that performs the steganography. It reads a bitmap image, extracts or inserts a secret message, and writes the modified bitmap image to a file.

## Key Features

- **Read Bitmap:** The program reads a bitmap image from a file.
- **Extract Secret Message:** The program can extract a secret message hidden within the bitmap image.
- **Insert Secret Message:** The program can insert a secret message into the bitmap image.
- **Write Bitmap:** The program writes the modified bitmap image (with the inserted secret message) to a file.

## Potential Improvements

While the program can perform basic steganography on bitmap images, there are several potential improvements that could be made:

- **Support for Other Image Formats:** The program currently only supports bitmap images. It could be extended to support other image formats, such as JPEG or PNG.
- **Improved Error Handling:** The program could include more robust error handling, for example to handle cases where the secret message is too large to fit in the image.
- **User Interface:** The program currently runs from the command line. A graphical user interface could be added to make it more user-friendly.
