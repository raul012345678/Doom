using UnityEngine;

[CreateAssetMenu(fileName = "Gundata", menuName = "Scriptable Objects/Gundata")]
public class GunData : ScriptableObject
{
   public float damage;

   public float fireRate;
   public int totalBullets;
   public float reloadTime; 
   public int cartridgeSize;
   public GunType gunType;
   public string shootSoundName;
   public string reloadSoundName;
   public string dropSoundName; 

}

public enum GunType
{
    Automatic,

    SemiAutomatic,

}
