//  ©️ 2024 by RF@EggNine.com All Rights Reserved
﻿namespace Eggnine.TrashTas.XUnit.SkipAttributes
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method)]
    public class SkipIfOsIsNot : SkipIf
    {
        public SkipIfOsIsNot(string operatingSystem)
        {
            OperatingSystem = operatingSystem;
        }

        public string OperatingSystem { get; }

        public override bool Matches(TrashContext ctx)
        {
            return !string.Equals(OperatingSystem, ctx.OperatingSystemName, StringComparison.OrdinalIgnoreCase);
        }

        public override string Reason(TrashContext ctx)
        {
            return $"OperatingSystemName is {ctx.OperatingSystemName} and not {OperatingSystem}";
        }
    }
}
