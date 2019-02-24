/// @description Insert description here
// You can write your code in this editor
key_left = keyboard_check(vk_left);
key_right = keyboard_check(vk_right);
key_jump = keyboard_check(vk_space);

var move = key_right - key_left;
acc=0.5 //Acceleration

hsp+=acc*(keyboard_check(vk_right) - keyboard_check(vk_left)) 

speed*=0.1 //Decreases the speed

if abs(speed) > 0
   {
   friction=1.00;
   }
else
   {
   friction=0;
   }


x = x + hsp;