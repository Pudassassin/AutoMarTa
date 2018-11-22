using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using Instructions;
using GameEntity;

namespace Automarta
{
    //Constants
    public class RobotConstant
    {
        public const int INSTRUCTION_PER_CYCLE = 50;
        public const int MAIN_MEM_SIZE = 16;
        public const int LIST_MEM_SIZE = 8;
    }

    //variable-type object
    public class Parameter
    {
        public Type Type { get { return m_Type; } }

        private object m_Value;
        private Type m_Type;

        public Parameter(bool value)
        {
            m_Type = typeof(bool);
            m_Value = value;
        }

        public Parameter(int value)
        {
            m_Type = typeof(int);
            m_Value = value;
        }

        public Parameter(float value)
        {
            m_Type = typeof(float);
            m_Value = value;
        }

        public Parameter(Vector2 value)
        {
            m_Type = typeof(Vector2);
            m_Value = value;
        }

        //****Okay?
        public Parameter(InstructionNode value)
        {
            m_Type = typeof(InstructionNode);
            m_Value = value;
        }

        public Parameter(Tag value)
        {
            m_Type = typeof(InstructionNode);
            m_Value = value;
        }

        public T GetValue<T>()
        {
            Type type = typeof(T);

            if (type.Equals(m_Type))
                return (T)m_Value;
            else
            {
                return default(T);
                //throw new Exception("Cannot get value as type " + type.FullName);
            }
        }
    }
}