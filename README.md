# The-Crypt-3D-Scan-Project
A collaborative project using 3D scans from the crypt venue in Camberwell. AV performance 
immersive installation 
## Links
<ul>
<li><a href="https://www.youtube.com/watch?v=zzSYYw-khpw">Audio Visual Demo</a></li>
<li><a href="https://www.youtube.com/watch?v=xj_bQgiA9XA">Latent Space Walkthrough</a></li>
<li><a href="/scripts/">Unity Scripts</a></li>
<li><a href="/point-files/">Point Cloud Files</a></li>
<li><a href="https://youtu.be/KsOUHFzbIe4">Play testing</a></li>
</ul>

## Individual Work

<ul>
<li><a href="">Ale's Work</a></li>
<li><a href="https://artslondon-my.sharepoint.com/:f:/g/personal/g_curtis0220231_arts_ac_uk/EoysP8X4Os5GgSUb1CGO8BMBiaZXZ0AiMHKJmbCwqvR5gQ?e=gNkRNr">Garin's Work</a></li>
<li><a href="https://artslondon-my.sharepoint.com/:f:/r/personal/d_manz0620231_arts_ac_uk/Documents/Assets?csf=1&web=1&e=qZIFB9">Dan M's Work</a></li>
<li><a href="">Dan H's Work</a></li>
</ul>

# Project Motivations & Context

## Introduction

We firmly believe that technology is a thrive for change in the world that we live in. The reality we have been used to, for hundreds of years, is recently being manipulated and distorted with novel technological methods. Somehow we will need to keep the sense of community with all these technological advances and build on top of history. Creating digital copies of historical places will help in the democratization of knowledge and amplify access for the population. The technological processes will bring AR and VR closer to everyday life, and this creates an important opportunity. The symbiotic relationship between arts and science is vital for creating this more accessible experiences while communicating and generating valuable insights for the community.<br>
The Crypt Project is a digital representation of the essence of a place. It is a multi-modal portrait of the crypt of St. Giles Church, its long history, the churchyard, its surroundings, and its jazz music venue. Using 3D and LiDAR scanning, AI, and environmental local data, we generate a symbiotic performance that intrinsically audio visualizes a space.
This installation bridges the past and future, offering a sensory experience that honors the church's legacy while showcasing the potential of modern innovation.<br>
We are drawing the past into the digital present, capturing the landmarks around us and permuting them into unseen configurations. The crypt plays a key part in the local community, both as a religious and cultural space. This project will create a line of communication between this site and the nearby CCI - encouraging dialogue between communities of people and between diverse approaches to creation.

## Technology & Tools

<em>The project is divided in three stages:</em>
The first stage is the collection of three dimensional and color data of the of the crypt and some segments of the outer facade of the church. These were collected using photogrammetry, LiDAR scanning and meshed together into a model using software such as COLMAP and Reality Capture. These models where then exported as color-dense point cloud files to permit interaction with Unity VFX and particle manipulation to create complex visual audio reactive results. We used the history of the church, trying to recreate the famous fire with the pointcloud patterns.<br>
The second stage is building a 1:1 scale 3D Gaussian Splatting for Real-Time Radiance Field Rendering model (3DGS). This innovative technique was published in July 2023 by Bernhard Kerbl*, Georgios Kopanas*, Thomas Leimkühler, George Drettakis (* indicates equal contribution) and it has, ever since, revolutionized 3D scanning and modelling due to its high quality and ability to run at higher FPS, allowing even to run in the browser. This will permit VR devices to easily run the model. <br>
The third stage is training a RAVE: A variational autoencoder for fast and high-quality neural audio synthesis (article link) by Antoine Caillon and Philippe Esling model with audio samples we have collected from the venue, the church, the graveyard and Peckham Road. This will permit the AI model to recreate a new audio using as input all the audio data from the church and surroundings.<br>

The RAVE model generates latent space, which is” a lower-dimensional space that captures the essential features of the input data.” Maverick, A.I. (2023).  We mapped the 3D high density point cloud to the latent space, so when you move through the space in Unity’s game mode you are actually moving through this compressed representation of the features. This can be added to the splat VR feature in the next iterations of the project.

## Process

We approached the owner of Jazz at The Crypt. Its location, just across the graveyard from Green Coat CCI make it strategic for an alliance. His technological vision made it easy to start working together. He had been waiting for the technology to catch up to make possible a digital version and consequent artistic manipulation of the Crypt.<br>
In total 4 different photoshoots 2 videos and 1 LiDAR Laser scan have been taken of the space. Each iteration building forward from previous mistakes. Being a Crypt, it has proven to be specifically hard to create a 3D model out of it, due to the dark nature of the space and therefore the lack of enough features for reconstruction. The first photoshoots were done with some of the furniture, which proved very difficult to replicate for the next photoshoots. We also tried different capturing data methods, such as photos, videos and laser scans. There is a high learning curve related with the pattern of the photos/videos for the 3D scanning, having to capture all of the angles of each part of the space. Usually 3D scanning is performed 360 degrees around a subject, in this specific case we were doing the opposite. <br>
Once the models were processed in the photogrammetry software, we used Unity gaming engine to manipulate the files. Each member of the team was in charge with a different point cloud, and there was an investigation process in order to get different result and aggregate in our knowledge of the system.<br>
There was the necessity of writing C# scripts in order to use the audio analysis in TouchDesigner and adjust parameters in Unity. The reason is that the Keijiro library (https://github.com/keijiro/LaspVfx) we were using could only read audio level while we needed more parameters to make the audio reactive element more dynamic and sensitive. It also didn’t work for creating an application, only for live performance.<br>
Another C# script was sending peak meter volume level from the MAX/msp latent space Rave output to the VFX graph position (x,z y)  parameters and gravity.

## Future Steps

We could use CCI Leica LiDAR scanner only once, and without the color data. Unfortunately CCI didn’t update the software, so this very expensive device is currently sitting in a shelf without being able to be used. It would be interesting to generate a LiDAR scan with color vertex information and test the camera of the laser scanner.<br>
There is a necessity for more high-quality photos and videos to aid the photogrammetry and Gaussian splatting algorithms. The current images are not enough to generate a high detail model of the crypt. Ideally it would be necessary a full-frame digital camera with good ISO sensitivity to capture low light images. We will continue the process until a high-quality 3D scan is achieved.
Once the model is done the idea would be to generate an immersive VR/AR experience in the 3DGS model where other point cloud audio reactive artworks can be displayed as in an art gallery.<br>
The VFX splat graph is not fully implemented as the technology is quite new, so its important new plug-ins are developed to be able to have more interactive and dynamic 3DGS models.

## Project Images
<small><em>This image is from an art installation titled "Embedded/Embodied" which the group visited in Amsterdam. The idea of physically exploring a ML model was a point of inspiration for the project. Source: https://www.arashakbari.com/embedded_embodied</em></small>
<image src="images/EmbeddedEmboddied.jpeg">
<small><em>This is from an installation by Ryoichi Kurokawa entitled "in s.asmbli". The digital representation, and deformity, of a physical space informed our approach. Source: https://www.ryoichikurokawa.com/project/ins.html</em></small>
<image src="images/ins_still_eq_4.jpg">
<small><em>Our group auditioned the installation at the Crypt venue in Camberwell. We would like to present the work as an exhibition here in the future.</em></small>
<image src="images/WhatsApp Image 2024-06-05 at 21.06.10_fa16c029.jpg">
<small><em>This was our first attempt at using post-processing in Unity. Here, we apply the "bloom" and "film grain" post-processing tools</em></small>
<image src="images/IMG_3576.jpg">
<small><em>Testing out VFX parameters with audio and a high density point cloud.</em></small>
<image src="images/IMG_3577.jpg">


## Play-test Feedback
<a href="https://youtu.be/KsOUHFzbIe4">Play testing</a>
<ul>
<li>Instead of revealing everything at once, build up the visuals in a crescendo style. Reveal new visual elements slowly.</li>
<li>The player capsule moves too fast - we should slow it down when using a joystick.</li>
<li>The visuals could have more diversity, we should integrate the other scans.</li>
</ul>

## References

<ul>
<li><a href="https://www.instagram.com/p/Cx-sj4sN-7L/">Ryoichi Kurokawa</a></li>
<li><a href="https://github.com/keijiro/VfxGraphAssets">Unity VFX Assets</a></li>
<li><a href="https://github.com/keijiro/LaspVfx">Keijiro LaspVFX</a></li>
<li><a href="https://github.com/keijiro/Pcx">Keijiro PCX</a></li>
<li><a href="https://github.com/keijiro/PlatVFX">Keijiro SplatVFX</a></li>
<li><a href="https://github.com/acids-ircam/RAVE">RAVE</a></li>
<li><a href="https://github.com/jonstephens85/gaussian-splatting-Windows">Gaussian Splatting</a></li>
<li><a href="https://samanemami.medium.com/a-comprehensive-guide-to-latent-space-9ae7f72bdb2f#:~:text=Latent%20space%20is%20a%20lower">Comprehensive Guide to Latent Space</a></li>
</ul>