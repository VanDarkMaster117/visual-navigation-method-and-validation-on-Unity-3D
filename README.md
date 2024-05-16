# visual-navigation-method-and-validation-on-Unity-3D

navigation system and validation in unity 3D
In scenarios such as inland rivers, automatic 
navigation for marine vessels is becoming more and more 
important. To improve the effect of automatic navigation, a 
visual navigation method based on machine learning for vessels 
is designed, and simulation validation is conducted. 

Firstly, vessel images are captured by using visual sensing technology. 
A semantic segmentation model is employed to separate the 
shoreline from the water region and identify the shoreline. 
Secondly, based on the identified shoreline, a reference anchor 
point is set for the vessel's navigation. The vessel's automatic 
navigation is achieved through a control algorithm. 
Finally, the proposed visual navigation method is validated through a 
simulation platform. Simulation experiments have shown that 
in simple inland waterway scenarios, the proposed method 
enables autonomous navigation of the vessel.


The 3D software used for simulation is Unity 2019.2.3f1, 
and the simulated water area is a small segment of the 
previously mentioned waterway. Using the camera in Unity 
3D, the vessel's perspective images are captured, and the 
SCNN algorithm is applied to perform segmentation of the 
shoreline and water area, identifying the left and right 
shorelines. Based on the recognized shorelines, reference 
anchor points for vessel navigation are extended, and the 
vessel's automatic navigation is achieved through a PID
control algorithm. The simulation experiments demonstrate 
that under this visual navigation approach, the vessel exhibits 
minimal lateral deviation during navigation in the inland 
waterway scene, achieving excellent performance. 
