Goals: 
	-Bullet hell style game that encourages the player to gamble on if they can complete a 
	level of various lengths.  
	-Ideally, each level will be randomly generated with payouts directly proportional to 
	length and difficulty.  
	-Payouts will allow the player to gain more power, different bullets, and armor.  
	-If the player is killed on the chosen mission, or quits they lose a portion of their 
	already existing wealth.  
	-I'm attempting to use a good chunk of the mechanics we will be and have discussed thus
	far in class. 
	-I want to make a lot of different kinds of bullets with various behaviors. I really make 
	some oscillating, whip-like bullets.  
 
Current State: 
	-Created a range detection system for enemy turrets to detect and track the player.  
	-Created a tracking system for the turret to follow the player after they enter the contact 
	sphere. 
	-Turrets fire on the player.  

Issues: 
	-Some turret guns move the barrel arrpropriately, others do not.  Inconsistant behavior.  I 
	believe it has to do with the local coordinate system on the turret cylinder. 

Controls: 
	-WA contols forward and stop.  
	-Directional arrows contol up,down,left,right turning.  
	-Left and right shift keys contol rotation of the "aircraft". 

Contact: rmccaffe@uno.edu
Repo: https://github.com/electriccheffer/SpecialTopicsProject  
