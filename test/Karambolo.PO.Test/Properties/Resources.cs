﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Karambolo.PO.Test.Properties
{
    public static class Resources
    {
        private static readonly Assembly s_assembly = typeof(Resources).Assembly;

        public static byte[] SamplePO
        {
            get
            {
                using (Stream stream = s_assembly.GetManifestResourceStream($"{s_assembly.GetName().Name}.Resources.sample.po"))
                using (var ms = new MemoryStream((int)stream.Length))
                {
                    stream.CopyTo(ms);
                    return ms.ToArray();
                }
            }
        }

        public static byte[] NewLineTestPO
        {
            get
            {
                using (Stream stream = s_assembly.GetManifestResourceStream($"{s_assembly.GetName().Name}.Resources.newlinetest.po"))
                using (var ms = new MemoryStream((int)stream.Length))
                {
                    stream.CopyTo(ms);
                    return ms.ToArray();
                }
            }
        }

        public static byte[] InvalidControlCharTestPO
        {
            get
            {
                using (Stream stream = s_assembly.GetManifestResourceStream($"{s_assembly.GetName().Name}.Resources.invalidcontrolchartest.po"))
                using (var ms = new MemoryStream((int)stream.Length))
                {
                    stream.CopyTo(ms);
                    return ms.ToArray();
                }
            }
        }
    }
}
