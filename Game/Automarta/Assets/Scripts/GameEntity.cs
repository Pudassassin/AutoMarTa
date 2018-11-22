using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Automarta;

namespace GameEntity
{
    public enum Tag
    {
        TypeRobot,
        TypeBuilding,
        TypeItem,
        TypeWorld,

        IsNeutral,
        IsFriend,
        IsEnemy,
        IsObjective,

        ResourceRaw,
        Resource,

        BuildSite,
        NeedResource,
        MarkedDemolish,

        CanMine,
        CanAttack,
        CanBuild,
        CanRepair,
        CanCarry,

        CanGlue,
        CanAcid,

        Storage,
        Refinery,
        TechWeapon,
        TechSupport,

        IsDamaged,
        IsGlued,
        IsAcidated
    }

    public enum EntityID
    {
        Robot_Worker,
        Robot_Miner,
        Robot_Builder,
        Robot_Melee,
        Robot_Tank,
        Robot_Mortar,
        Robot_Repair,
        Robot_Glue,

        Building_LMC,
        Building_Factory,
        Building_BuilderBay,
        Building_Refinery,
        Building_Warehouse,
        Building_Armory,
        Building_FrontierLab,

        Mecha_Drone,
        Mecha_Warrior,
        Mecha_Spine,
        Mecha_Acid,
        Mecha_Ram,

        Nest_Hive,
        Nest_Spawner,
        Nest_Pile,
        Nest_Carrier,

        Item_BlackBox,
        Item_Ore,
        Item_Resource,
        Item_Sample
    }

    public struct Ability
    {
        public Tag ability;
        public List<Parameter> param;
    }

    public struct Status
    {
        public Tag type;
        public int duration;
    }

    public class EntityObject
    {
        public String Name;
        public EntityID Type;
        public List<Tag> Tags;
        public List<Ability> Abilities;
        public List<Status> Status;
        public Vector2 Position;
        public float MaxHP, HP;
        public float Armor;

        //public String GetName()
        //{
        //    return Name;
        //}

        //public void SetName(String value)
        //{
        //    Name = value;
        //}

        //public List<Tag> GetTags()
        //{
        //    return Tags;
        //}

        //public Vector2 GetPosition()
        //{
        //    return Position;
        //}

        //public float GetMaxHP()
        //{
        //    return MaxHP;
        //}

        //public float GetArmor()
        //{
        //    return Armor;
        //}

        public float GetHpPercent()
        {
            return 100.0f * HP / MaxHP;
        }
    }
    

}
