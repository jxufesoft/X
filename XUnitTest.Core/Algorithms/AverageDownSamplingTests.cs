﻿using System;
using System.Collections.Generic;
using System.IO;
using NewLife.Algorithms;
using NewLife.Data;
using NewLife.IO;
using Xunit;

namespace XUnitTest.Algorithms
{
    public class AverageDownSamplingTests
    {
        //[Fact]
        //public void DivTest()
        //{
        //    var n = 1234L;
        //    var d1 = n / 3;
        //    var d2 = n / 4;
        //    Assert.Equal(411, d1);
        //    Assert.Equal(308, d2);

        //    Assert.Equal(411, (n + 1) / 3);
        //    Assert.Equal(412, (n + 2) / 3);
        //}

        [Fact]
        public void Normal500()
        {
            var data = ReadPoints();

            var sample = new AverageSampling();
            var rs = sample.Down(data, 500);
            Assert.NotNull(rs);
            Assert.Equal(500, rs.Length);

            //var k = 0;
            //using var csv2 = new CsvFile("Algorithms/rs.csv");
            //while (true)
            //{
            //    var line = csv2.ReadLine();
            //    if (line == null) break;

            //    Assert.Equal(line[0].ToInt(), rs[k].Time);
            //    Assert.True(Math.Abs(line[1].ToDouble() - rs[k].Value) < 0.0001);

            //    k++;
            //}

            WritePoints(rs, sample.AlignMode);
        }

        private TimePoint[] ReadPoints()
        {
            using var csv = new CsvFile("Algorithms/source.csv");
            var data = new List<TimePoint>();
            while (true)
            {
                var line = csv.ReadLine();
                if (line == null) break;

                data.Add(new TimePoint { Time = line[0].ToLong(), Value = line[1].ToDouble() });
            }
            return data.ToArray();
        }

        private void WritePoints(TimePoint[] data, AlignModes mode)
        {
            var f = $"Algorithms/avg_{mode}_sampled.csv".GetFullPath();
            if (File.Exists(f)) File.Delete(f);
            using var csv = new CsvFile(f, true);
            for (var i = 0; i < data.Length; i++)
            {
                csv.WriteLine(data[i].Time, data[i].Value);
            }
            csv.Dispose();

            //XTrace.WriteLine(f);
        }

        [Fact]
        public void AlignLeftTest()
        {
            var data = ReadPoints();
            var sample = new AverageSampling { AlignMode = AlignModes.Left };
            var rs = sample.Down(data, 100);
            Assert.NotNull(rs);
            Assert.Equal(100, rs.Length);

            WritePoints(rs, sample.AlignMode);
        }

        [Fact]
        public void AlignRightTest()
        {
            var data = ReadPoints();
            var sample = new AverageSampling { AlignMode = AlignModes.Right };
            var rs = sample.Down(data, 500);
            Assert.NotNull(rs);
            Assert.Equal(500, rs.Length);

            WritePoints(rs, sample.AlignMode);
        }

        [Fact]
        public void AlignCenterTest()
        {
            var data = ReadPoints();
            var sample = new AverageSampling { AlignMode = AlignModes.Center };
            var rs = sample.Down(data, 500);
            Assert.NotNull(rs);
            Assert.Equal(500, rs.Length);

            WritePoints(rs, sample.AlignMode);
        }

        //[Fact]
        //public void FixedBucketAlignRightTest()
        //{
        //    var data = ReadPoints();
        //    var sample = new AverageDownSampling { AlignMode = AlignModes.Right, BucketSize = 60, BucketOffset = 5 };
        //    var rs = sample.Down(data, 500);
        //    Assert.NotNull(rs);
        //    Assert.Equal(100, rs.Length);
        //    Assert.Equal(5, rs[0].Time);
        //    Assert.Equal(65, rs[1].Time);
        //    Assert.Equal(125, rs[2].Time);

        //    WritePoints(rs, sample.AlignMode);
        //}
    }
}