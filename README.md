# PixIn
Picture Repository Web Api

Simple APSNET Core 2.1 Web Api.

1) configure the root directory of the repository in the PixInSettings.json configuration file.

2) host images in sub directories of the root directory.

3) call controller to gain collection as a dictionary<string, byte[]> where the 'key' is the name of the image including extension
and 'value' is the image data as byte[], base64.

controller -> host:port/api/images/[sub directory]

Demo Angular application can be found in Repo stephenwike/PixInDemo
