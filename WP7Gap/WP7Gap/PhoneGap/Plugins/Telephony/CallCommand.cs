﻿//-----------------------------------------------------------------------
// <copyright file="CallCommand.cs">
//     Copyright © 2010. All rights reserved.
// </copyright>
// <author>Matt Lacey</author>
//-----------------------------------------------------------------------
using Microsoft.Phone.Tasks;

namespace PhoneGap.Plugins.Telephony
{
    public class CallCommand : PhoneGapCommand
    {
        public override void Execute(params string[] args)
        {
            var pct = new PhoneCallTask { PhoneNumber = args[0] };
            pct.Show();
        }
    }
}
