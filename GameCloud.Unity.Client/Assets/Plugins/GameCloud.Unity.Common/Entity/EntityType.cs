﻿// Copyright (c) Cragon. All rights reserved.

namespace GameCloud.Unity.Common
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;
    using ProtoBuf;

    //-------------------------------------------------------------------------
    //[Serializable]
    //[ProtoContract]
    //public class ComponentData
    //{
    //    [ProtoMember(1)]
    //    public string component_name;// 组件类工厂名
    //    [ProtoMember(2)]
    //    public Dictionary<string, string> def_propset;// 组件定义类属性集
    //}

    //-------------------------------------------------------------------------
    [Serializable]
    [ProtoContract]
    public class EntityData
    {
        [ProtoMember(1)]
        public string entity_type;// ==entity_def_name
        [ProtoMember(2)]
        public string entity_guid;
        [ProtoMember(3)]
        //public List<ComponentData> list_component;
        public Dictionary<string, Dictionary<string, string>> map_component;
        [NonSerialized]
        public Dictionary<string, object> cache_data;
        [ProtoMember(4)]
        public List<EntityData> entity_children;
    }

    //[Serializable]
    //[ProtoContract]
    //public class EntityTransform
    //{
    //    //---------------------------------------------------------------------
    //    [ProtoMember(1)]
    //    public EbVector3 position;
    //    [ProtoMember(2)]
    //    public EbVector3 rotation;

    //    //---------------------------------------------------------------------
    //    public override bool Equals(object obj)
    //    {
    //        if (obj == null) return false;
    //        if (obj is EntityTransform)
    //        {
    //            var other = (EntityTransform)obj;
    //            return this.position.Equals(other.position) && this.rotation.Equals(other.rotation);
    //        }
    //        return false;
    //    }

    //    //---------------------------------------------------------------------
    //    public static bool operator ==(EntityTransform left, EntityTransform right)
    //    {
    //        if (System.Object.ReferenceEquals(left, right))
    //        {
    //            return true;
    //        }

    //        if ((object)left == null)
    //        {
    //            if ((object)right == null)
    //            {
    //                return false;
    //            }
    //        }

    //        return left.Equals(right);
    //    }

    //    //---------------------------------------------------------------------
    //    public static bool operator !=(EntityTransform left, EntityTransform right)
    //    {
    //        return !left.Equals(right);
    //    }

    //    //---------------------------------------------------------------------
    //    public override int GetHashCode()
    //    {
    //        return base.GetHashCode();
    //    }

    //    //---------------------------------------------------------------------
    //    public Dictionary<byte, object> toDic()
    //    {
    //        Dictionary<byte, object> m = new Dictionary<byte, object>();
    //        m[0] = position.x;
    //        m[1] = position.y;
    //        m[2] = position.z;
    //        m[3] = rotation.x;
    //        m[4] = rotation.y;
    //        m[5] = rotation.z;
    //        return m;
    //    }

    //    //---------------------------------------------------------------------
    //    public void fromDic(Dictionary<byte, object> m)
    //    {
    //        position.x = (float)m[0];
    //        position.y = (float)m[1];
    //        position.z = (float)m[2];
    //        rotation.x = (float)m[3];
    //        rotation.y = (float)m[4];
    //        rotation.z = (float)m[5];
    //    }
    //}
}
