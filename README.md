# Unity Art Gallery

## Disclaimer
This project was created as part of a group project for the CS 196 class at UIUC in the Fall 2019 semester. This repository was copied from the original private repo on Gitlab with full permission on January 6th, 2021.

## Description
This is a VR art gallery created using Unity and coded in C#, displaying images selected by the user in the virtual environment. The gallery is also capable of displaying animated .gif files - however, the file must first be manually separated into its individual frames. This is because although the functionality to automate the splitting of .gif files into individual frames exists in C#, it is not supported in Unity. Furthermore, while this project was intended to be for a VR environment, it was never tested with a VR headset due to a lack of equipment. 

## Instructions
1. Download or clone the files in the repository to your local device. 
2. After opening Unity Hub, add the `TestRoom` folder. `TestRoom` should now appear in the UnityHub listing as a project. Click on it to open the project in Unity.
3. Each image display in the gallery has a corresponding C# script to retrieve image data, handle image lighting, and animate .gif files if necessary. To display an image in the gallery, simply add the images into the corresponding folder under the `Resources` folder so that the script can retrieve the files under the filepath.
    1. For example, if you wanted to set the image on the East wall, you would simply clear all the other images under `Resources/EastWallImages` before adding your desired image into the folder. 
    2. For .gif files, it is necessary to label the frames with numbers in the order with which they will be played so that the script can animate the gif in the proper order.
    3. **Note:** It may be necessary to add the corresponding folders, as many of the empty folders were lost while transferring from Gitlab
4. When you are ready, press the `Play` button to view the updated images and animated gifs.
