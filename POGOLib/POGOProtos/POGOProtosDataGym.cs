// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos.Data.Gym.proto

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;

namespace POGOProtos.Data.Gym
{
    /// <summary>Holder for reflection information generated from POGOProtos.Data.Gym.proto</summary>
    public static partial class POGOProtosDataGymReflection
    {
        #region Descriptor

        /// <summary>File descriptor for POGOProtos.Data.Gym.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static pbr::FileDescriptor descriptor;

        static POGOProtosDataGymReflection()
        {
            var descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                    "ChlQT0dPUHJvdG9zLkRhdGEuR3ltLnByb3RvEhNQT0dPUHJvdG9zLkRhdGEu",
                    "R3ltGhVQT0dPUHJvdG9zLkRhdGEucHJvdG8aHFBPR09Qcm90b3MuRGF0YS5Q",
                    "bGF5ZXIucHJvdG8aGVBPR09Qcm90b3MuTWFwLkZvcnQucHJvdG8ikAEKDUd5",
                    "bU1lbWJlcnNoaXASMgoMcG9rZW1vbl9kYXRhGAEgASgLMhwuUE9HT1Byb3Rv",
                    "cy5EYXRhLlBva2Vtb25EYXRhEksKFnRyYWluZXJfcHVibGljX3Byb2ZpbGUY",
                    "AiABKAsyKy5QT0dPUHJvdG9zLkRhdGEuUGxheWVyLlBsYXllclB1YmxpY1By",
                    "b2ZpbGUidQoIR3ltU3RhdGUSMAoJZm9ydF9kYXRhGAEgASgLMh0uUE9HT1By",
                    "b3Rvcy5NYXAuRm9ydC5Gb3J0RGF0YRI3CgttZW1iZXJzaGlwcxgCIAMoCzIi",
                    "LlBPR09Qcm90b3MuRGF0YS5HeW0uR3ltTWVtYmVyc2hpcFAAUAFQAmIGcHJv",
                    "dG8z"));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[]
                {
                    global::POGOProtos.Data.POGOProtosDataReflection.Descriptor,
                    global::POGOProtos.Data.Player.POGOProtosDataPlayerReflection.Descriptor,
                    global::POGOProtos.Map.Fort.POGOProtosMapFortReflection.Descriptor,
                },
                new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[]
                {
                    new pbr::GeneratedClrTypeInfo(typeof (global::POGOProtos.Data.Gym.GymMembership),
                        global::POGOProtos.Data.Gym.GymMembership.Parser, new[] {"PokemonData", "TrainerPublicProfile"},
                        null, null, null),
                    new pbr::GeneratedClrTypeInfo(typeof (global::POGOProtos.Data.Gym.GymState),
                        global::POGOProtos.Data.Gym.GymState.Parser, new[] {"FortData", "Memberships"}, null, null, null)
                }));
        }

        #endregion
    }

    #region Messages

    public sealed partial class GymMembership : pb::IMessage<GymMembership>
    {
        /// <summary>Field number for the "pokemon_data" field.</summary>
        public const int PokemonDataFieldNumber = 1;

        /// <summary>Field number for the "trainer_public_profile" field.</summary>
        public const int TrainerPublicProfileFieldNumber = 2;

        private static readonly pb::MessageParser<GymMembership> _parser =
            new pb::MessageParser<GymMembership>(() => new GymMembership());

        private global::POGOProtos.Data.PokemonData pokemonData_;
        private global::POGOProtos.Data.Player.PlayerPublicProfile trainerPublicProfile_;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GymMembership()
        {
            OnConstruction();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GymMembership(GymMembership other) : this()
        {
            PokemonData = other.pokemonData_ != null ? other.PokemonData.Clone() : null;
            TrainerPublicProfile = other.trainerPublicProfile_ != null ? other.TrainerPublicProfile.Clone() : null;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<GymMembership> Parser
        {
            get { return _parser; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::POGOProtos.Data.Gym.POGOProtosDataGymReflection.Descriptor.MessageTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::POGOProtos.Data.PokemonData PokemonData
        {
            get { return pokemonData_; }
            set { pokemonData_ = value; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::POGOProtos.Data.Player.PlayerPublicProfile TrainerPublicProfile
        {
            get { return trainerPublicProfile_; }
            set { trainerPublicProfile_ = value; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GymMembership Clone()
        {
            return new GymMembership(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(GymMembership other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(PokemonData, other.PokemonData)) return false;
            if (!Equals(TrainerPublicProfile, other.TrainerPublicProfile)) return false;
            return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (pokemonData_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(PokemonData);
            }
            if (trainerPublicProfile_ != null)
            {
                output.WriteRawTag(18);
                output.WriteMessage(TrainerPublicProfile);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            var size = 0;
            if (pokemonData_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonData);
            }
            if (trainerPublicProfile_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(TrainerPublicProfile);
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(GymMembership other)
        {
            if (other == null)
            {
                return;
            }
            if (other.pokemonData_ != null)
            {
                if (pokemonData_ == null)
                {
                    pokemonData_ = new global::POGOProtos.Data.PokemonData();
                }
                PokemonData.MergeFrom(other.PokemonData);
            }
            if (other.trainerPublicProfile_ != null)
            {
                if (trainerPublicProfile_ == null)
                {
                    trainerPublicProfile_ = new global::POGOProtos.Data.Player.PlayerPublicProfile();
                }
                TrainerPublicProfile.MergeFrom(other.TrainerPublicProfile);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                    {
                        if (pokemonData_ == null)
                        {
                            pokemonData_ = new global::POGOProtos.Data.PokemonData();
                        }
                        input.ReadMessage(pokemonData_);
                        break;
                    }
                    case 18:
                    {
                        if (trainerPublicProfile_ == null)
                        {
                            trainerPublicProfile_ = new global::POGOProtos.Data.Player.PlayerPublicProfile();
                        }
                        input.ReadMessage(trainerPublicProfile_);
                        break;
                    }
                }
            }
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as GymMembership);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            var hash = 1;
            if (pokemonData_ != null) hash ^= PokemonData.GetHashCode();
            if (trainerPublicProfile_ != null) hash ^= TrainerPublicProfile.GetHashCode();
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    public sealed partial class GymState : pb::IMessage<GymState>
    {
        /// <summary>Field number for the "fort_data" field.</summary>
        public const int FortDataFieldNumber = 1;

        /// <summary>Field number for the "memberships" field.</summary>
        public const int MembershipsFieldNumber = 2;

        private static readonly pb::MessageParser<GymState> _parser =
            new pb::MessageParser<GymState>(() => new GymState());

        private static readonly pb::FieldCodec<global::POGOProtos.Data.Gym.GymMembership> _repeated_memberships_codec
            = pb::FieldCodec.ForMessage(18, global::POGOProtos.Data.Gym.GymMembership.Parser);

        private readonly pbc::RepeatedField<global::POGOProtos.Data.Gym.GymMembership> memberships_ =
            new pbc::RepeatedField<global::POGOProtos.Data.Gym.GymMembership>();

        private global::POGOProtos.Map.Fort.FortData fortData_;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GymState()
        {
            OnConstruction();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GymState(GymState other) : this()
        {
            FortData = other.fortData_ != null ? other.FortData.Clone() : null;
            memberships_ = other.memberships_.Clone();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<GymState> Parser
        {
            get { return _parser; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::POGOProtos.Data.Gym.POGOProtosDataGymReflection.Descriptor.MessageTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::POGOProtos.Map.Fort.FortData FortData
        {
            get { return fortData_; }
            set { fortData_ = value; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::POGOProtos.Data.Gym.GymMembership> Memberships
        {
            get { return memberships_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GymState Clone()
        {
            return new GymState(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(GymState other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (!Equals(FortData, other.FortData)) return false;
            if (!memberships_.Equals(other.memberships_)) return false;
            return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (fortData_ != null)
            {
                output.WriteRawTag(10);
                output.WriteMessage(FortData);
            }
            memberships_.WriteTo(output, _repeated_memberships_codec);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            var size = 0;
            if (fortData_ != null)
            {
                size += 1 + pb::CodedOutputStream.ComputeMessageSize(FortData);
            }
            size += memberships_.CalculateSize(_repeated_memberships_codec);
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(GymState other)
        {
            if (other == null)
            {
                return;
            }
            if (other.fortData_ != null)
            {
                if (fortData_ == null)
                {
                    fortData_ = new global::POGOProtos.Map.Fort.FortData();
                }
                FortData.MergeFrom(other.FortData);
            }
            memberships_.Add(other.memberships_);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                    {
                        if (fortData_ == null)
                        {
                            fortData_ = new global::POGOProtos.Map.Fort.FortData();
                        }
                        input.ReadMessage(fortData_);
                        break;
                    }
                    case 18:
                    {
                        memberships_.AddEntriesFrom(input, _repeated_memberships_codec);
                        break;
                    }
                }
            }
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as GymState);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            var hash = 1;
            if (fortData_ != null) hash ^= FortData.GetHashCode();
            hash ^= memberships_.GetHashCode();
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    #endregion
}

#endregion Designer generated code