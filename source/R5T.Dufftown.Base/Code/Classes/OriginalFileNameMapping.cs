﻿using System;

using R5T.Sparta;


namespace R5T.Dufftown
{
    public class OriginalFileNameMapping
    {
        #region Static

        public static OriginalFileNameMapping New(FileName uniqueFileName, FileName originalFileName)
        {
            var output = new OriginalFileNameMapping(uniqueFileName, originalFileName);
            return output;
        }

        #endregion


        public FileName UniqueFileName { get; }
        public FileName OriginalFileName { get; }


        public OriginalFileNameMapping(FileName uniqueFileName, FileName originalFileName)
        {
            this.UniqueFileName = uniqueFileName;
            this.OriginalFileName = originalFileName;
        }
    }
}
