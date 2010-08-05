﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmos.Compiler.Assembler.X86.X {
    public class Ports {
       public PortNumber this[RegisterDX aDX] {
            get {
                return new PortNumber(aDX.GetId());
            }
            set {
                if (value.Register == Registers.EAX || value.Register == Registers.AX || value.Register == Registers.AL)
                    new Out { DestinationReg = value.Register };
                else
                    throw new Exception("Invalid destination register for OUT");
            }
        }
    }
}