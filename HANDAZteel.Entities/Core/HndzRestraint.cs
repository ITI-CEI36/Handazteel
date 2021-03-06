﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace HANDAZ.Entities
{
    public class HndzRestraint:HndzRoot
    {
        public HndzRestraint(bool u1, bool u2, bool u3, bool r1, bool r2, bool r3):this()
        {
            U1 = u1;
            U2 = u2;
            U3 = u3;
            R1 = r1;
            R2 = r2;
            R3 = r3;
        }
        public HndzRestraint(HndzRestraintEnum support)
        {
            switch (support)
            {
                case HndzRestraintEnum.Roller:
                    U3 = true;
                    break;
                case HndzRestraintEnum.Pinned:
                    U2 = true;
                    U1 = true;
                    U3 = true;
                    break;
                case HndzRestraintEnum.Fixed:
                    U1 = true;
                    U2 = true;
                    U3 = true;
                    R1 = true;
                    R2 = true;
                    R3 = true;
                    break;
                default:
                    break;
            }
        }

        public HndzRestraint()
        {
            values = new bool[6];
        }

        private bool u1 = false;

        public bool U1
        {
            get { return u1; }
            set
            {
                u1 = value;
                Values[0] = U1;
            }
        }
        private bool u2 = false;

        public bool U2
        {
            get { return u2; }
            set
            {
                u2 = value;
                Values[1] = U2;
            }
        }
        private bool u3 = false;

        public bool U3
        {
            get { return u3; }
            set
            {
                u3 = value;
                Values[2] = U3;
            }
        }
        private bool r1 = false;

        public bool R1
        {
            get { return r1; }
            set
            {
                r1 = value;
                Values[3] = R1;
            }
        }
        private bool r2 = false;

        public bool R2
        {
            get { return r2; }
            set
            {
                r2 = value;
                Values[4] = R2;
            }
        }
        private bool r3 = false;

        public bool R3
        {
            get { return r3; }
            set
            {
                r3 = value;
                Values[5] = R3;
            }
        }

        internal bool[] values;

        internal bool[] Values
        {
            get { return values; }
            set { values = value; }
        }

    }
}
