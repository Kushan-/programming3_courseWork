﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kushan_lab05_ex01_Test_
{
    public class ListNode
    {

        // automatic read-only property Data
        public double Data { get; private set; }

        // automatic property Next
        public ListNode Next { get; set; }

        // constructor to create ListNode that refers to dataValue
        // and is last node in list
        public ListNode(double dataValue) : this(dataValue, null) { }

        // constructor to create ListNode that refers to dataValue
        // and refers to next ListNode in List
        public ListNode(double dataValue, ListNode nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }
}
