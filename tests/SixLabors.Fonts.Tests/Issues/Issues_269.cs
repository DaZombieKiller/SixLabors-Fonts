// Copyright (c) Six Labors.
// Licensed under the Apache License, Version 2.0.

using Xunit;

namespace SixLabors.Fonts.Tests.Issues
{
    public class Issues_269
    {
        [Fact]
        public void CorrectlySetsMetricsForFontsNotAdheringToSpec()
        {
            // AliceFrancesHMK has invalid subtables.
            Font font = new FontCollection().Add(TestFonts.AliceFrancesHMKRegularFile).CreateFont(25);

            FontRectangle size = TextMeasurer.Measure("H", new TextOptions(font));

            Assert.Equal(32, size.Width, 1);
            Assert.Equal(31, size.Height, 1);
        }
    }
}
