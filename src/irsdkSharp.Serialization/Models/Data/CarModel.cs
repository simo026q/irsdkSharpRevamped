﻿using IrSdkSharp.Models;
using System;
using System.Collections.Generic;

namespace irsdkSharp.Serialization.Models.Data
{
    public class CarModel
    {
        private readonly byte[] _data;
        private readonly Dictionary<string, VarHeader> _headers;
        public CarModel(int idx, byte[] data, Dictionary<string, VarHeader> headers)
        {
            CarIdx = idx;
            _data = data;
            _headers = headers;

        }

        public CarModel(
            int idx,
            int carIdxBestLapNum,
            float carIdxBestLapTime,
            int carIdxClassPosition,
            float carIdxEstTime,
            float carIdxF2Time,
            int carIdxGear,
            int carIdxLap,
            int carIdxLapCompleted,
            float carIdxLapDistPct,
            float carIdxLastLapTime,
            bool carIdxOnPitRoad,
            int carIdxP2P_Count,
            bool carIdxP2P_Status,
            int carIdxPosition,
            float carIdxRPM,
            float carIdxSteer,
            int carIdxTrackSurface,
            int carIdxTrackSurfaceMaterial
            )
        {
            CarIdx = idx;
            _carIdxBestLapNum = carIdxBestLapNum;
            _carIdxBestLapTime = carIdxBestLapTime;
            _carIdxClassPosition = carIdxClassPosition;
            _carIdxEstTime = carIdxEstTime;
            _carIdxF2Time = carIdxF2Time;
            _carIdxGear = carIdxGear;
            _carIdxLap = carIdxLap;
            _carIdxLapCompleted = carIdxLapCompleted;
            _carIdxLapDistPct = carIdxLapDistPct;
            _carIdxLastLapTime = carIdxLastLapTime;
            _carIdxOnPitRoad = carIdxOnPitRoad;
            _carIdxP2P_Count = carIdxP2P_Count;
            _carIdxP2P_Status = carIdxP2P_Status;
            _carIdxPosition = carIdxPosition;
            _carIdxRPM = carIdxRPM;
            _carIdxSteer = carIdxSteer;
            _carIdxTrackSurface = carIdxTrackSurface;
            _carIdxTrackSurfaceMaterial = carIdxTrackSurfaceMaterial;
        }


        public int CarIdx { get; }

        private int? _carIdxBestLapNum;
        public int CarIdxBestLapNum
        {
            get
            {
                if (!_carIdxBestLapNum.HasValue) _carIdxBestLapNum = ValueSerializer.GetIntValue(nameof(CarIdxBestLapNum), _data, _headers, CarIdx);
                return _carIdxBestLapNum.Value;
            }
        }

        private float? _carIdxBestLapTime;
        public float CarIdxBestLapTime
        {
            get
            {
                if (!_carIdxBestLapTime.HasValue) _carIdxBestLapTime = ValueSerializer.GetFloatValue(nameof(CarIdxBestLapTime), _data, _headers, CarIdx);
                return _carIdxBestLapTime.Value;
            }
        }

        private int? _carIdxClassPosition;
        public int CarIdxClassPosition
        {
            get
            {
                if (!_carIdxClassPosition.HasValue) _carIdxClassPosition = ValueSerializer.GetIntValue(nameof(CarIdxClassPosition), _data, _headers, CarIdx);
                return _carIdxClassPosition.Value;
            }
        }

        private float? _carIdxEstTime;
        public float CarIdxEstTime
        {
            get
            {
                if (!_carIdxEstTime.HasValue) _carIdxEstTime = ValueSerializer.GetFloatValue(nameof(CarIdxEstTime), _data, _headers, CarIdx);
                return _carIdxEstTime.Value;
            }
        }

        private float? _carIdxF2Time;
        public float CarIdxF2Time
        {
            get
            {
                if (!_carIdxF2Time.HasValue) _carIdxF2Time = ValueSerializer.GetFloatValue(nameof(CarIdxF2Time), _data, _headers, CarIdx);
                return _carIdxF2Time.Value;
            }
        }

        private int? _carIdxGear;
        public int CarIdxGear
        {
            get
            {
                if (!_carIdxGear.HasValue) _carIdxGear = ValueSerializer.GetIntValue(nameof(CarIdxGear), _data, _headers, CarIdx);
                return _carIdxGear.Value;
            }
        }

        private int? _carIdxLap;
        public int CarIdxLap
        {
            get
            {
                if (!_carIdxLap.HasValue) _carIdxLap = ValueSerializer.GetIntValue(nameof(CarIdxLap), _data, _headers, CarIdx);
                return _carIdxLap.Value;
            }
        }

        private int? _carIdxLapCompleted;
        public int CarIdxLapCompleted
        {
            get
            {
                if (!_carIdxLapCompleted.HasValue) _carIdxLapCompleted = ValueSerializer.GetIntValue(nameof(CarIdxLapCompleted), _data, _headers, CarIdx);
                return _carIdxLapCompleted.Value;
            }
        }

        private float? _carIdxLapDistPct;
        public float CarIdxLapDistPct
        {
            get
            {
                if (!_carIdxLapDistPct.HasValue) _carIdxLapDistPct = ValueSerializer.GetFloatValue(nameof(CarIdxLapDistPct), _data, _headers, CarIdx);
                return _carIdxLapDistPct.Value;
            }
        }

        private float? _carIdxLastLapTime;
        public float CarIdxLastLapTime
        {
            get
            {
                if (!_carIdxLastLapTime.HasValue) _carIdxLastLapTime = ValueSerializer.GetFloatValue(nameof(CarIdxLastLapTime), _data, _headers, CarIdx);
                return _carIdxLastLapTime.Value;
            }
        }

        private bool? _carIdxOnPitRoad;
        public bool CarIdxOnPitRoad
        {
            get
            {
                if (!_carIdxOnPitRoad.HasValue) _carIdxOnPitRoad = ValueSerializer.GetBoolValue(nameof(CarIdxOnPitRoad), _data, _headers, CarIdx);
                return _carIdxOnPitRoad.Value;
            }
        }

        private int? _carIdxP2P_Count;
        public int CarIdxP2P_Count
        {
            get
            {
                if (!_carIdxP2P_Count.HasValue) _carIdxP2P_Count = ValueSerializer.GetIntValue(nameof(CarIdxP2P_Count), _data, _headers, CarIdx);
                return _carIdxP2P_Count.Value;
            }
        }

        private bool? _carIdxP2P_Status;
        public bool CarIdxP2P_Status
        {
            get
            {
                if (!_carIdxP2P_Status.HasValue) _carIdxP2P_Status = ValueSerializer.GetBoolValue(nameof(CarIdxP2P_Status), _data, _headers, CarIdx);
                return _carIdxP2P_Status.Value;
            }
        }

        private int? _carIdxPosition;
        public int CarIdxPosition
        {
            get
            {
                if (!_carIdxPosition.HasValue) _carIdxPosition = ValueSerializer.GetIntValue(nameof(CarIdxPosition), _data, _headers, CarIdx);
                return _carIdxPosition.Value;
            }
        }

        private float? _carIdxRPM;
        public float CarIdxRPM
        {
            get
            {
                if (!_carIdxRPM.HasValue) _carIdxRPM = ValueSerializer.GetFloatValue(nameof(CarIdxRPM), _data, _headers, CarIdx);
                return _carIdxRPM.Value;
            }
        }

        private float? _carIdxSteer;
        public float CarIdxSteer
        {
            get
            {
                if (!_carIdxSteer.HasValue) _carIdxSteer = ValueSerializer.GetFloatValue(nameof(CarIdxSteer), _data, _headers, CarIdx);
                return _carIdxSteer.Value;
            }
        }

        private int? _carIdxTrackSurface;
        public int CarIdxTrackSurface
        {
            get
            {
                if (!_carIdxTrackSurface.HasValue) _carIdxTrackSurface = _headers.TryGetValue(nameof(CarIdxTrackSurface), out var header)
                                                                            ? BitConverter.ToInt32(_data, header.Offset + (4 * CarIdx))
                                                                            : -1;  
                return _carIdxTrackSurface.Value;
            }
        }

        private int? _carIdxTrackSurfaceMaterial;
        public int CarIdxTrackSurfaceMaterial
        {
            get
            {
                if (!_carIdxTrackSurfaceMaterial.HasValue) _carIdxTrackSurfaceMaterial = _headers.TryGetValue(nameof(CarIdxTrackSurfaceMaterial), out var header)
                                                                            ? BitConverter.ToInt32(_data, header.Offset + (4 * CarIdx))
                                                                            : -1;
                return _carIdxTrackSurfaceMaterial.Value;
            }
        }

        private int? _carIdxClass;
        public int CarIdxClass
        {
            get
            {
                if (!_carIdxClass.HasValue) _carIdxClass = ValueSerializer.GetIntValue(nameof(CarIdxClass), _data, _headers, CarIdx);
                return _carIdxClass.Value;
            }
        }

        private int? _carIdxTireCompound;
        public int CarIdxTireCompound
        {
            get
            {
                if (!_carIdxTireCompound.HasValue) _carIdxTireCompound = ValueSerializer.GetIntValue(nameof(CarIdxTireCompound), _data, _headers, CarIdx);
                return _carIdxTireCompound.Value;
            }
        }

        private int? _carIdxQualTireCompound;
        public int CarIdxQualTireCompound
        {
            get
            {
                if (!_carIdxQualTireCompound.HasValue) _carIdxQualTireCompound = ValueSerializer.GetIntValue(nameof(CarIdxQualTireCompound), _data, _headers, CarIdx);
                return _carIdxQualTireCompound.Value;
            }
        }

        private bool? _carIdxQualTireCompoundLocked;
        public bool CarIdxQualTireCompoundLocked
        {
            get
            {
                if (!_carIdxQualTireCompoundLocked.HasValue) _carIdxQualTireCompoundLocked = ValueSerializer.GetBoolValue(nameof(CarIdxQualTireCompoundLocked), _data, _headers, CarIdx);
                return _carIdxQualTireCompoundLocked.Value;
            }
        }

        private int? _carIdxFastRepairsUsed;
        public int CarIdxFastRepairsUsed
        {
            get
            {
                if (!_carIdxFastRepairsUsed.HasValue) _carIdxFastRepairsUsed = ValueSerializer.GetIntValue(nameof(CarIdxFastRepairsUsed), _data, _headers, CarIdx);
                return _carIdxFastRepairsUsed.Value;
            }
        }

        private int? _carIdxSessionFlags;
        public int CarIdxSessionFlags
        {
            get
            {
                if (!_carIdxSessionFlags.HasValue) _carIdxSessionFlags = ValueSerializer.GetIntValue(nameof(CarIdxSessionFlags), _data, _headers, CarIdx);
                return _carIdxSessionFlags.Value;
            }
        }

        private int? _carIdxPaceLine;
        public int CarIdxPaceLine
        {
            get
            {
                if (!_carIdxPaceLine.HasValue) _carIdxPaceLine = ValueSerializer.GetIntValue(nameof(CarIdxPaceLine), _data, _headers, CarIdx);
                return _carIdxPaceLine.Value;
            }
        }

        private int? _carIdxPaceRow;
        public int CarIdxPaceRow
        {
            get
            {
                if (!_carIdxPaceRow.HasValue) _carIdxPaceRow = ValueSerializer.GetIntValue(nameof(CarIdxPaceRow), _data, _headers, CarIdx);
                return _carIdxPaceRow.Value;
            }
        }

        private int? _carIdxPaceFlags;
        public int CarIdxPaceFlags
        {
            get
            {
                if (!_carIdxPaceFlags.HasValue) _carIdxPaceFlags = ValueSerializer.GetIntValue(nameof(CarIdxPaceFlags), _data, _headers, CarIdx);
                return _carIdxPaceFlags.Value;
            }
        }
    }
}
