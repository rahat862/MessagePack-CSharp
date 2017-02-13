﻿using System;
using System.Linq;
using System.IO;
using Xunit;

namespace MessagePack.Tests
{
    public class MessagePackBinaryTest
    {
        (MemoryStream, MsgPack.Packer) CreateReferencePacker()
        {
            var ms = new MemoryStream();
            var packer = MsgPack.Packer.Create(ms, MsgPack.PackerCompatibilityOptions.None);
            return (ms, packer);
        }

        MsgPack.MessagePackObject CreateUnpackedReference(byte[] bytes)
        {
            var ms = new MemoryStream(bytes);
            var unpacker = MsgPack.Unpacker.Create(ms);
            unpacker.Read();
            return unpacker.LastReadData;
        }

        [Fact]
        public void NilTest()
        {
            (var stream, var packer) = CreateReferencePacker();

            byte[] bytes = null;
            MessagePackBinary.WriteNil(ref bytes, 0).Is(1);

            packer.PackNull().Position.Is(bytes.Length);
            stream.ToArray().SequenceEqual(bytes);

            int readSize;
            MessagePackBinary.ReadNil(bytes, 0, out readSize).Is(Nil.Default);
            readSize.Is(1);

            CreateUnpackedReference(bytes).IsNil.IsTrue();
        }

        [Theory]
        [InlineData(true, 1)]
        [InlineData(false, 1)]
        public void BoolTest(bool target, int length)
        {
            (var stream, var packer) = CreateReferencePacker();

            byte[] bytes = null;
            MessagePackBinary.WriteBoolean(ref bytes, 0, target).Is(length);

            packer.Pack(target).Position.Is(bytes.Length);
            stream.ToArray().SequenceEqual(bytes);

            int readSize;
            MessagePackBinary.ReadBoolean(bytes, 0, out readSize).Is(target);
            readSize.Is(length);

            CreateUnpackedReference(bytes).AsBoolean().Is(target);
        }

        [Theory]
        [InlineData(byte.MinValue, 1)]
        [InlineData(111, 1)]
        [InlineData(136, 2)]
        [InlineData(byte.MaxValue, 2)]
        public void ByteTest(byte target, int length)
        {
            (var stream, var packer) = CreateReferencePacker();

            byte[] bytes = null;
            MessagePackBinary.WriteByte(ref bytes, 0, target).Is(length);

            packer.Pack(target).Position.Is(bytes.Length);
            stream.ToArray().SequenceEqual(bytes);

            int readSize;
            MessagePackBinary.ReadByte(bytes, 0, out readSize).Is(target);
            readSize.Is(length);

            CreateUnpackedReference(bytes).AsByte().Is(target);
        }

        public static object[] bytesTestData = new object[]
        {
            new object[]{ (byte[])null, 1 },
            new object[]{ new byte[] { }, 2 },
            new object[]{ new byte[] { 1, 2, 3 }, 5 },
            new object[]{ Enumerable.Repeat((byte)100, byte.MaxValue).ToArray(), 255 + 2 },
            new object[]{ Enumerable.Repeat((byte)100, UInt16.MaxValue).ToArray(), 65535 + 3 },
            new object[]{ Enumerable.Repeat((byte)100, 99999).ToArray(), 99999 + 5 },
        };

        [Theory]
        [MemberData(nameof(bytesTestData))]
        public void BytesTest(byte[] target, int length)
        {
            (var stream, var packer) = CreateReferencePacker();

            byte[] bytes = null;
            MessagePackBinary.WriteBytes(ref bytes, 0, target).Is(length);

            packer.PackBinary(target).Position.Is(bytes.Length);
            stream.ToArray().SequenceEqual(bytes);

            int readSize;
            MessagePackBinary.ReadBytes(bytes, 0, out readSize).Is(target);
            readSize.Is(length);

            CreateUnpackedReference(bytes).AsBinary().Is(target);
        }

        [Theory]
        [InlineData(sbyte.MinValue, 2)]
        [InlineData(-100, 2)]
        [InlineData(-33, 2)]
        [InlineData(-32, 1)]
        [InlineData(-31, 1)]
        [InlineData(-30, 1)]
        [InlineData(-1, 1)]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(126, 1)]
        [InlineData(sbyte.MaxValue, 1)]
        public void SByteTest(sbyte target, int length)
        {
            (var stream, var packer) = CreateReferencePacker();

            byte[] bytes = null;
            MessagePackBinary.WriteSByte(ref bytes, 0, target).Is(length);

            packer.Pack(target).Position.Is(bytes.Length);
            stream.ToArray().SequenceEqual(bytes);

            int readSize;
            MessagePackBinary.ReadSByte(bytes, 0, out readSize).Is(target);
            readSize.Is(length);

            CreateUnpackedReference(bytes).AsSByte().Is(target);
        }

        [Theory]
        [InlineData(Single.MinValue, 5)]
        [InlineData(0.0f, 5)]
        [InlineData(12345.6789f, 5)]
        [InlineData(-12345.6789f, 5)]
        [InlineData(Single.MaxValue, 5)]
        [InlineData(Single.NaN, 5)]
        [InlineData(Single.PositiveInfinity, 5)]
        [InlineData(Single.NegativeInfinity, 5)]
        [InlineData(Single.Epsilon, 5)]
        public void SingleTest(Single target, int length)
        {
            (var stream, var packer) = CreateReferencePacker();

            byte[] bytes = null;
            MessagePackBinary.WriteSingle(ref bytes, 0, target).Is(length);

            packer.Pack(target).Position.Is(bytes.Length);
            stream.ToArray().SequenceEqual(bytes);

            int readSize;
            MessagePackBinary.ReadSingle(bytes, 0, out readSize).Is(target);
            readSize.Is(length);

            CreateUnpackedReference(bytes).AsSingle().Is(target);
        }

        [Theory]
        [InlineData(Double.MinValue, 9)]
        [InlineData(0.0, 9)]
        [InlineData(12345.6789, 9)]
        [InlineData(-12345.6789, 9)]
        [InlineData(Double.MaxValue, 9)]
        [InlineData(Double.NaN, 9)]
        [InlineData(Double.PositiveInfinity, 9)]
        [InlineData(Double.NegativeInfinity, 9)]
        [InlineData(Double.Epsilon, 9)]
        public void DoubleTest(Double target, int length)
        {
            (var stream, var packer) = CreateReferencePacker();

            byte[] bytes = null;
            MessagePackBinary.WriteDouble(ref bytes, 0, target).Is(length);

            packer.Pack(target).Position.Is(bytes.Length);
            stream.ToArray().SequenceEqual(bytes);

            int readSize;
            MessagePackBinary.ReadDouble(bytes, 0, out readSize).Is(target);
            readSize.Is(length);

            CreateUnpackedReference(bytes).AsDouble().Is(target);
        }
    }
}
