﻿// <copyright file="PacketHeaders.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

//------------------------------------------------------------------------------
// <auto-generated>
//     This source code was auto-generated by an XSL transformation.
//     Do not change this file. Instead, change the XML data which contains
//     the packet definitions and re-run the transformation (rebuild this project).
// </auto-generated>
//------------------------------------------------------------------------------

namespace MUnique.OpenMU.Network.Packets
{
    using System;

    /// <summary>
    /// The structure for a C1 packet header. Usually encrypted by Xor32..
    /// </summary>
    public ref struct C1Header
    {
        private Span<byte> data;

        /// <summary>
        /// Initializes a new instance of the <see cref="C1Header"/> struct.
        /// </summary>
        /// <param name="data">The underlying data.</param>
        public C1Header(Span<byte> data)
        {
            this.data = data;
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public byte Type
        {
            get => this.data[0];
            set => this.data[0] = value;
        }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        public byte Length
        {
            get => this.data[1];
            set => this.data[1] = value;
        }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public byte Code
        {
            get => this.data[2];
            set => this.data[2] = value;
        }
    }


    /// <summary>
    /// The structure for a C1 packet header with sub code. Usually encrypted by Xor32..
    /// </summary>
    public ref struct C1HeaderWithSubCode
    {
        private Span<byte> data;

        /// <summary>
        /// Initializes a new instance of the <see cref="C1HeaderWithSubCode"/> struct.
        /// </summary>
        /// <param name="data">The underlying data.</param>
        public C1HeaderWithSubCode(Span<byte> data)
        {
            this.data = data;
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public byte Type
        {
            get => this.data[0];
            set => this.data[0] = value;
        }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        public byte Length
        {
            get => this.data[1];
            set => this.data[1] = value;
        }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public byte Code
        {
            get => this.data[2];
            set => this.data[2] = value;
        }

        /// <summary>
        /// Gets or sets the sub code.
        /// </summary>
        public byte SubCode
        {
            get => this.data[3];
            set => this.data[3] = value;
        }
    }


    /// <summary>
    /// The structure for a C2 packet header. Usually encrypted by Xor32..
    /// </summary>
    public ref struct C2Header
    {
        private Span<byte> data;

        /// <summary>
        /// Initializes a new instance of the <see cref="C2Header"/> struct.
        /// </summary>
        /// <param name="data">The underlying data.</param>
        public C2Header(Span<byte> data)
        {
            this.data = data;
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public byte Type
        {
            get => this.data[0];
            set => this.data[0] = value;
        }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        public ushort Length
        {
            get => this.data.Slice(1).GetShortLittleEndian();
            set => this.data.Slice(1).SetShortLittleEndian(value);
        }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public byte Code
        {
            get => this.data[3];
            set => this.data[3] = value;
        }
    }


    /// <summary>
    /// The structure for a C3 packet header. Usually encrypted by Xor32 and SimpleModulus..
    /// </summary>
    public ref struct C3Header
    {
        private Span<byte> data;

        /// <summary>
        /// Initializes a new instance of the <see cref="C3Header"/> struct.
        /// </summary>
        /// <param name="data">The underlying data.</param>
        public C3Header(Span<byte> data)
        {
            this.data = data;
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public byte Type
        {
            get => this.data[0];
            set => this.data[0] = value;
        }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        public byte Length
        {
            get => this.data[1];
            set => this.data[1] = value;
        }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public byte Code
        {
            get => this.data[2];
            set => this.data[2] = value;
        }
    }


    /// <summary>
    /// The structure for a C3 packet header with sub code. Usually encrypted by Xor32 and SimpleModulus..
    /// </summary>
    public ref struct C3HeaderWithSubCode
    {
        private Span<byte> data;

        /// <summary>
        /// Initializes a new instance of the <see cref="C3HeaderWithSubCode"/> struct.
        /// </summary>
        /// <param name="data">The underlying data.</param>
        public C3HeaderWithSubCode(Span<byte> data)
        {
            this.data = data;
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public byte Type
        {
            get => this.data[0];
            set => this.data[0] = value;
        }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        public byte Length
        {
            get => this.data[1];
            set => this.data[1] = value;
        }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public byte Code
        {
            get => this.data[2];
            set => this.data[2] = value;
        }

        /// <summary>
        /// Gets or sets the sub code.
        /// </summary>
        public byte SubCode
        {
            get => this.data[3];
            set => this.data[3] = value;
        }
    }


    /// <summary>
    /// The structure for a C4 packet header. Usually encrypted by Xor32 and SimpleModulus..
    /// </summary>
    public ref struct C4Header
    {
        private Span<byte> data;

        /// <summary>
        /// Initializes a new instance of the <see cref="C4Header"/> struct.
        /// </summary>
        /// <param name="data">The underlying data.</param>
        public C4Header(Span<byte> data)
        {
            this.data = data;
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public byte Type
        {
            get => this.data[0];
            set => this.data[0] = value;
        }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        public ushort Length
        {
            get => this.data.Slice(1).GetShortLittleEndian();
            set => this.data.Slice(1).SetShortLittleEndian(value);
        }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public byte Code
        {
            get => this.data[3];
            set => this.data[3] = value;
        }
    }


    /// <summary>
    /// The structure for a C4 packet header with sub code. Usually encrypted by Xor32 and SimpleModulus..
    /// </summary>
    public ref struct C4HeaderWithSubCode
    {
        private Span<byte> data;

        /// <summary>
        /// Initializes a new instance of the <see cref="C4HeaderWithSubCode"/> struct.
        /// </summary>
        /// <param name="data">The underlying data.</param>
        public C4HeaderWithSubCode(Span<byte> data)
        {
            this.data = data;
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public byte Type
        {
            get => this.data[0];
            set => this.data[0] = value;
        }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        public ushort Length
        {
            get => this.data.Slice(1).GetShortLittleEndian();
            set => this.data.Slice(1).SetShortLittleEndian(value);
        }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public byte Code
        {
            get => this.data[3];
            set => this.data[3] = value;
        }

        /// <summary>
        /// Gets or sets the sub code.
        /// </summary>
        public byte SubCode
        {
            get => this.data[4];
            set => this.data[4] = value;
        }
    }
}