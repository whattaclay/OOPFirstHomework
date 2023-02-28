using System.Threading.Channels;

var knight = new HomeWork.Knight();
knight.swordLength = 10;
var archer = new HomeWork.Archer();
archer.archeryDistance = 200;
var mage = new HomeWork.Mage();
mage.squareDamage = 15;
 
knight.Attack();
archer.Attack();
mage.Attack();
