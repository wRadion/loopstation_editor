﻿using System.Xml.Serialization;

using Loopstation.Xml.Interfaces;
using Loopstation.Xml.Utils;

namespace Loopstation.Xml.Memory
{
    public class XmlFxSettings : ICloneable<XmlFxSettings>
    {
        private int _filterType;
        private int _filterRate;
        private int _filterDepth;
        private int _filterResonance;
        private int _filterCutoff;
        private int _filterStepRate;
        private int _phaserRate;
        private int _phaserDepth;
        private int _phaserResonance;
        private int _phaserStepRate;
        private int _phaserLevel;
        private int _flangerRate;
        private int _flangerDepth;
        private int _flangerResonance;
        private int _flangerStepRate;
        private int _flangerLevel;
        private int _synthFrequency;
        private int _synthResonance;
        private int _synthDecay;
        private int _synthBalance;
        private int _loFiDepth;
        private int _loFiSampleRate;
        private int _loFiBalance;
        private int _ringModulatorFrequency;
        private int _ringModulatorBalance;
        private int _guitarToBassBalance;
        private int _slowGearSensitivity;
        private int _slowGearRiseTime;
        private int _slowGearLevel;
        private int _transpose;
        private int _pitchBendOctave;
        private int _pitchBendBend;
        private int _robotNote;
        private int _robotGender;
        private int _vocalDistDistortion;
        private int _vocalDistTone;
        private int _vocalDistLevel;
        private int _vocoderCarrier;
        private int _vocoderModSens;
        private int _vocoderAttack;
        private int _vocoderBalance;
        private int _dynamicsType;
        private int _dynamicsDynamics;
        private int _eqLow;
        private int _eqLowMid;
        private int _eqHighMid;
        private int _eqHigh;
        private int _eqLevel;
        private int _isolatorBand;
        private int _isolatorRate;
        private int _isolatorDepth;
        private int _isolatorStepRate;
        private int _isolatorLevel;
        private int _octaveMode;
        private int _octaveLevel;
        private int _panType;
        private int _panRate;
        private int _panDepth;
        private int _panStepRate;
        private int _panPosition;
        private int _tremoloRate;
        private int _tremoloDepth;
        private int _tremoloLevel;
        private int _slicerPattern;
        private int _slicerRate;
        private int _slicerDepth;
        private int _delayTime;
        private int _delayFeedback;
        private int _delayLevel;
        private int _panningDelayTime;
        private int _panningDelayFeedback;
        private int _panningDelayLevel;
        private int _tapeEchoRate;
        private int _tapeEchoIntensity;
        private int _tapeEchoLevel;
        private int _granularDelayTime;
        private int _granularDelayFeedback;
        private int _granularDelayLevel;
        private int _rollTime;
        private int _rollMode;
        private int _rollFeedback;
        private int _rollLevel;
        private int _chorusRate;
        private int _chorusDepth;
        private int _chorusLevel;
        private int _reverbTime;
        private int _reverbLevel;
        private int _reverbDryLevel;

        /// <summary>
        /// Integer from <c>0</c> to <c>2</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("FilTyp")]
        public int FilterType
        {
            get => _filterType;
            set => _filterType = Range.Guard(value, max: 2);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>114</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("FilRat")]
        public int FilterRate
        {
            get => _filterRate;
            set => _filterRate = Range.Guard(value, max: 114);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>55</c>.</para>
        /// </summary>
        [XmlElement("FilDep")]
        public int FilterDepth
        {
            get => _filterDepth;
            set => _filterDepth = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("FilReso")]
        public int FilterResonance
        {
            get => _filterResonance;
            set => _filterResonance = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("FilCut")]
        public int FilterCutoff
        {
            get => _filterCutoff;
            set => _filterCutoff = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>115</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("FilStpRat")]
        public int FilterStepRate
        {
            get => _filterStepRate;
            set => _filterStepRate = Range.Guard(value, max: 115);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>114</c>.
        /// <para>Default value is <c>70</c>.</para>
        /// </summary>
        [XmlElement("PhRat")]
        public int PhaserRate
        {
            get => _phaserRate;
            set => _phaserRate = Range.Guard(value, max: 114);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("PhDep")]
        public int PhaserDepth
        {
            get => _phaserDepth;
            set => _phaserDepth = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("PhReso")]
        public int PhaserResonance
        {
            get => _phaserResonance;
            set => _phaserResonance = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>115</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("PhStpRat")]
        public int PhaserStepRate
        {
            get => _phaserStepRate;
            set => _phaserStepRate = Range.Guard(value, max: 115);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("PhLvl")]
        public int PhaserLevel
        {
            get => _phaserLevel;
            set => _phaserLevel = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>114</c>.
        /// <para>Default value is <c>25</c>.</para>
        /// </summary>
        [XmlElement("FlRat")]
        public int FlangerRate
        {
            get => _flangerRate;
            set => _flangerRate = Range.Guard(value, max: 114);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("FlDep")]
        public int FlangerDepth
        {
            get => _flangerDepth;
            set => _flangerDepth = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>70</c>.</para>
        /// </summary>
        [XmlElement("FlReso")]
        public int FlangerResonance
        {
            get => _flangerResonance;
            set => _flangerResonance = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>115</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("FlStpRat")]
        public int FlangerStepRate
        {
            get => _flangerStepRate;
            set => _flangerStepRate = Range.Guard(value, max: 115);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("FlLvl")]
        public int FlangerLevel
        {
            get => _flangerLevel;
            set => _flangerLevel = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("SynFreq")]
        public int SynthFrequency
        {
            get => _synthFrequency;
            set => _synthFrequency = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("SynReso")]
        public int SynthResonance
        {
            get => _synthResonance;
            set => _synthResonance = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("SynDecay")]
        public int SynthDecay
        {
            get => _synthDecay;
            set => _synthDecay = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>90</c>.</para>
        /// </summary>
        [XmlElement("SynBal")]
        public int SynthBalance
        {
            get => _synthBalance;
            set => _synthBalance = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>15</c>.
        /// <para>Default value is <c>8</c>.</para>
        /// </summary>
        [XmlElement("LoFiDep")]
        public int LoFiDepth
        {
            get => _loFiDepth;
            set => _loFiDepth = Range.Guard(value, max: 15);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>31</c>.
        /// <para>Default value is <c>15</c>.</para>
        /// </summary>
        [XmlElement("LoFiSmpl")]
        public int LoFiSampleRate
        {
            get => _loFiSampleRate;
            set => _loFiSampleRate = Range.Guard(value, max: 31);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("LoFiBal")]
        public int LoFiBalance
        {
            get => _loFiBalance;
            set => _loFiBalance = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("RmFreq")]
        public int RingModulatorFrequency
        {
            get => _ringModulatorFrequency;
            set => _ringModulatorFrequency = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>100</c>.</para>
        /// </summary>
        [XmlElement("RmBal")]
        public int RingModulatorBalance
        {
            get => _ringModulatorBalance;
            set => _ringModulatorBalance = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("GToB")]
        public int GuitarToBassBalance
        {
            get => _guitarToBassBalance;
            set => _guitarToBassBalance = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>40</c>.</para>
        /// </summary>
        [XmlElement("SgSens")]
        public int SlowGearSensitivity
        {
            get => _slowGearSensitivity;
            set => _slowGearSensitivity = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("SgRisTim")]
        public int SlowGearRiseTime
        {
            get => _slowGearRiseTime;
            set => _slowGearRiseTime = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("SgLvl")]
        public int SlowGearLevel
        {
            get => _slowGearLevel;
            set => _slowGearLevel = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>24</c>.
        /// <para>Default value is <c>12</c>.</para>
        /// </summary>
        [XmlElement("Trans")]
        public int Transpose
        {
            get => _transpose;
            set => _transpose = Range.Guard(value, max: 24);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>7</c>.
        /// <para>Default value is <c>2</c>.</para>
        /// </summary>
        [XmlElement("PbPit")]
        public int PitchBendOctave
        {
            get => _pitchBendOctave;
            set => _pitchBendOctave = Range.Guard(value, max: 7);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>100</c>.</para>
        /// </summary>
        [XmlElement("PbBnd")]
        public int PitchBendBend
        {
            get => _pitchBendBend;
            set => _pitchBendBend = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>11</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("RoboNote")]
        public int RobotNote
        {
            get => _robotNote;
            set => _robotNote = Range.Guard(value, max: 11);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>20</c>.
        /// <para>Default value is <c>10</c>.</para>
        /// </summary>
        [XmlElement("RoboGen")]
        public int RobotGender
        {
            get => _robotGender;
            set => _robotGender = Range.Guard(value, max: 20);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("DistDist")]
        public int VocalDistDistortion
        {
            get => _vocalDistDistortion;
            set => _vocalDistDistortion = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("DistTon")]
        public int VocalDistTone
        {
            get => _vocalDistTone;
            set => _vocalDistTone = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("DistLvl")]
        public int VocalDistLevel
        {
            get => _vocalDistLevel;
            set => _vocalDistLevel = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>4</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("VocoCar")]
        public int VocoderCarrier
        {
            get => _vocoderCarrier;
            set => _vocoderCarrier = Range.Guard(value, max: 4);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("VocoSens")]
        public int VocoderModSens
        {
            get => _vocoderModSens;
            set => _vocoderModSens = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("VocoAtck")]
        public int VocoderAttack
        {
            get => _vocoderAttack;
            set => _vocoderAttack = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("VocoBal")]
        public int VocoderBalance
        {
            get => _vocoderBalance;
            set => _vocoderBalance = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>18</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("DynmTyp")]
        public int DynamicsType
        {
            get => _dynamicsType;
            set => _dynamicsType = Range.Guard(value, max: 18);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>40</c>.
        /// <para>Default value is <c>20</c>.</para>
        /// </summary>
        [XmlElement("DynmDynm")]
        public int DynamicsDynamics
        {
            get => _dynamicsDynamics;
            set => _dynamicsDynamics = Range.Guard(value, max: 40);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>40</c>.
        /// <para>Default value is <c>20</c>.</para>
        /// </summary>
        [XmlElement("EqLo")]
        public int EqLow
        {
            get => _eqLow;
            set => _eqLow = Range.Guard(value, max: 40);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>40</c>.
        /// <para>Default value is <c>20</c>.</para>
        /// </summary>
        [XmlElement("EqLoMd")]
        public int EqLowMid
        {
            get => _eqLowMid;
            set => _eqLowMid = Range.Guard(value, max: 40);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>40</c>.
        /// <para>Default value is <c>20</c>.</para>
        /// </summary>
        [XmlElement("EqHiMd")]
        public int EqHighMid
        {
            get => _eqHighMid;
            set => _eqHighMid = Range.Guard(value, max: 40);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>40</c>.
        /// <para>Default value is <c>20</c>.</para>
        /// </summary>
        [XmlElement("EqHi")]
        public int EqHigh
        {
            get => _eqHigh;
            set => _eqHigh = Range.Guard(value, max: 40);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>40</c>.
        /// <para>Default value is <c>20</c>.</para>
        /// </summary>
        [XmlElement("EqLvl")]
        public int EqLevel
        {
            get => _eqLevel;
            set => _eqLevel = Range.Guard(value, max: 40);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>2</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("IsoBnd")]
        public int IsolatorBand
        {
            get => _isolatorBand;
            set => _isolatorBand = Range.Guard(value, max: 2);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>114</c>.
        /// <para>Default value is <c>103</c>.</para>
        /// </summary>
        [XmlElement("IsoRat")]
        public int IsolatorRate
        {
            get => _isolatorRate;
            set => _isolatorRate = Range.Guard(value, max: 114);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>100</c>.</para>
        /// </summary>
        [XmlElement("IsoDep")]
        public int IsolatorDepth
        {
            get => _isolatorDepth;
            set => _isolatorDepth = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>115</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("IsoStpRat")]
        public int IsolatorStepRate
        {
            get => _isolatorStepRate;
            set => _isolatorStepRate = Range.Guard(value, max: 115);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>100</c>.</para>
        /// </summary>
        [XmlElement("IsoLvl")]
        public int IsolatorLevel
        {
            get => _isolatorLevel;
            set => _isolatorLevel = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>2</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("OctMod")]
        public int OctaveMode
        {
            get => _octaveMode;
            set => _octaveMode = Range.Guard(value, max: 2);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("OctLvl")]
        public int OctaveLevel
        {
            get => _octaveLevel;
            set => _octaveLevel = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>2</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("PanTyp")]
        public int PanType
        {
            get => _panType;
            set => _panType = Range.Guard(value, max: 2);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>114</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("PanRat")]
        public int PanRate
        {
            get => _panRate;
            set => _panRate = Range.Guard(value, max: 114);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("PanDep")]
        public int PanDepth
        {
            get => _panDepth;
            set => _panDepth = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>115</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("PanStpRat")]
        public int PanStepRate
        {
            get => _panStepRate;
            set => _panStepRate = Range.Guard(value, max: 115);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("PanPos")]
        public int PanPosition
        {
            get => _panPosition;
            set => _panPosition = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>114</c>.
        /// <para>Default value is <c>85</c>.</para>
        /// </summary>
        [XmlElement("TrRat")]
        public int TremoloRate
        {
            get => _tremoloRate;
            set => _tremoloRate = Range.Guard(value, max: 114);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("TrDep")]
        public int TremoloDepth
        {
            get => _tremoloDepth;
            set => _tremoloDepth = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("TrLvl")]
        public int TremoloLevel
        {
            get => _tremoloLevel;
            set => _tremoloLevel = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>19</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("SlPat")]
        public int SlicerPattern
        {
            get => _slicerPattern;
            set => _slicerPattern = Range.Guard(value, max: 19);
        }

        // 110 114
        [XmlElement("SlRat")]
        public int SlicerRate
        {
            get => _slicerRate;
            set => _slicerRate = Range.Guard(value, max: 114);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>100</c>.</para>
        /// </summary>
        [XmlElement("SlDep")]
        public int SlicerDepth
        {
            get => _slicerDepth;
            set => _slicerDepth = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1011</c>.
        /// <para>Default value is <c>200</c>.</para>
        /// </summary>
        [XmlElement("DlyTim")]
        public int DelayTime
        {
            get => _delayTime;
            set => _delayTime = Range.Guard(value, max: 1011);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>20</c>.</para>
        /// </summary>
        [XmlElement("DlyFb")]
        public int DelayFeedback
        {
            get => _delayFeedback;
            set => _delayFeedback = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("DlyLvl")]
        public int DelayLevel
        {
            get => _delayLevel;
            set => _delayLevel = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1011</c>.
        /// <para>Default value is <c>200</c>.</para>
        /// </summary>
        [XmlElement("PanDlyTim")]
        public int PanningDelayTime
        {
            get => _panningDelayTime;
            set => _panningDelayTime = Range.Guard(value, max: 1011);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>20</c>.</para>
        /// </summary>
        [XmlElement("PanDlyFb")]
        public int PanningDelayFeedback
        {
            get => _panningDelayFeedback;
            set => _panningDelayFeedback = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("PanDlyLvl")]
        public int PanningDelayLevel
        {
            get => _panningDelayLevel;
            set => _panningDelayLevel = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("EchRat")]
        public int TapeEchoRate
        {
            get => _tapeEchoRate;
            set => _tapeEchoRate = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("EchInt")]
        public int TapeEchoIntensity
        {
            get => _tapeEchoIntensity;
            set => _tapeEchoIntensity = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("EchLvl")]
        public int TapeEchoLevel
        {
            get => _tapeEchoLevel;
            set => _tapeEchoLevel = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("GraTim")]
        public int GranularDelayTime
        {
            get => _granularDelayTime;
            set => _granularDelayTime = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>70</c>.</para>
        /// </summary>
        [XmlElement("GraFb")]
        public int GranularDelayFeedback
        {
            get => _granularDelayFeedback;
            set => _granularDelayFeedback = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("GraLvl")]
        public int GranularDelayLevel
        {
            get => _granularDelayLevel;
            set => _granularDelayLevel = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1011</c>.
        /// <para>Default value is <c>1008</c>.</para>
        /// </summary>
        [XmlElement("RllTim")]
        public int RollTime
        {
            get => _rollTime;
            set => _rollTime = Range.Guard(value, max: 1011);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>4</c>.
        /// <para>Default value is <c>2</c>.</para>
        /// </summary>
        [XmlElement("RllMod")]
        public int RollMode
        {
            get => _rollMode;
            set => _rollMode = Range.Guard(value, max: 4);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>20</c>.</para>
        /// </summary>
        [XmlElement("RllFb")]
        public int RollFeedback
        {
            get => _rollFeedback;
            set => _rollFeedback = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("RllLvl")]
        public int RollLevel
        {
            get => _rollLevel;
            set => _rollLevel = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>114</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("ChoRat")]
        public int ChorusRate
        {
            get => _chorusRate;
            set => _chorusRate = Range.Guard(value, max: 114);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("ChoDep")]
        public int ChorusDepth
        {
            get => _chorusDepth;
            set => _chorusDepth = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("ChoLvl")]
        public int ChorusLevel
        {
            get => _chorusLevel;
            set => _chorusLevel = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>1</c> to <c>100</c>.
        /// <para>Default value is <c>27</c>.</para>
        /// </summary>
        [XmlElement("RevTim")]
        public int ReverbTime
        {
            get => _reverbTime;
            set => _reverbTime = Range.Guard(value, min: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("RevLvl")]
        public int ReverbLevel
        {
            get => _reverbLevel;
            set => _reverbLevel = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>100</c>.</para>
        /// </summary>
        [XmlElement("RevDLvl")]
        public int ReverbDryLevel
        {
            get => _reverbDryLevel;
            set => _reverbDryLevel = Range.Guard(value);
        }

        public XmlFxSettings() : this(null) { }
        public XmlFxSettings(XmlFxSettings other)
        {
            FilterType             = other?.FilterType             ?? 0;
            FilterRate             = other?.FilterRate             ?? 50;
            FilterDepth            = other?.FilterDepth            ?? 55;
            FilterResonance        = other?.FilterResonance        ?? 50;
            FilterCutoff           = other?.FilterCutoff           ?? 50;
            FilterStepRate         = other?.FilterStepRate         ?? 0;
            PhaserRate             = other?.PhaserRate             ?? 70;
            PhaserDepth            = other?.PhaserDepth            ?? 50;
            PhaserResonance        = other?.PhaserResonance        ?? 0;
            PhaserStepRate         = other?.PhaserStepRate         ?? 0;
            PhaserLevel            = other?.PhaserLevel            ?? 50;
            FlangerRate            = other?.FlangerRate            ?? 25;
            FlangerDepth           = other?.FlangerDepth           ?? 50;
            FlangerResonance       = other?.FlangerResonance       ?? 70;
            FlangerStepRate        = other?.FlangerStepRate        ?? 0;
            FlangerLevel           = other?.FlangerLevel           ?? 50;
            SynthFrequency         = other?.SynthFrequency         ?? 50;
            SynthResonance         = other?.SynthResonance         ?? 50;
            SynthDecay             = other?.SynthDecay             ?? 50;
            SynthBalance           = other?.SynthBalance           ?? 90;
            LoFiDepth              = other?.LoFiDepth              ?? 8;
            LoFiSampleRate         = other?.LoFiSampleRate         ?? 15;
            LoFiBalance            = other?.LoFiBalance            ?? 50;
            RingModulatorFrequency = other?.RingModulatorFrequency ?? 50;
            RingModulatorBalance   = other?.RingModulatorBalance   ?? 100;
            GuitarToBassBalance    = other?.GuitarToBassBalance    ?? 50;
            SlowGearSensitivity    = other?.SlowGearSensitivity    ?? 40;
            SlowGearRiseTime       = other?.SlowGearRiseTime       ?? 50;
            SlowGearLevel          = other?.SlowGearLevel          ?? 50;
            Transpose              = other?.Transpose              ?? 12;
            PitchBendOctave        = other?.PitchBendOctave        ?? 2;
            PitchBendBend          = other?.PitchBendBend          ?? 100;
            RobotNote              = other?.RobotNote              ?? 0;
            RobotGender            = other?.RobotGender            ?? 10;
            VocalDistDistortion    = other?.VocalDistDistortion    ?? 50;
            VocalDistTone          = other?.VocalDistTone          ?? 50;
            VocalDistLevel         = other?.VocalDistLevel         ?? 50;
            VocoderCarrier         = other?.VocoderCarrier         ?? 0;
            VocoderModSens         = other?.VocoderModSens         ?? 50;
            VocoderAttack          = other?.VocoderAttack          ?? 50;
            VocoderBalance         = other?.VocoderBalance         ?? 50;
            DynamicsType           = other?.DynamicsType           ?? 0;
            DynamicsDynamics       = other?.DynamicsDynamics       ?? 20;
            EqLow                  = other?.EqLow                  ?? 20;
            EqLowMid               = other?.EqLowMid               ?? 20;
            EqHighMid              = other?.EqHighMid              ?? 20;
            EqHigh                 = other?.EqHigh                 ?? 20;
            EqLevel                = other?.EqLevel                ?? 20;
            IsolatorBand           = other?.IsolatorBand           ?? 0;
            IsolatorRate           = other?.IsolatorRate           ?? 103;
            IsolatorDepth          = other?.IsolatorDepth          ?? 100;
            IsolatorStepRate       = other?.IsolatorStepRate       ?? 0;
            IsolatorLevel          = other?.IsolatorLevel          ?? 100;
            OctaveMode             = other?.OctaveMode             ?? 0;
            OctaveLevel            = other?.OctaveLevel            ?? 50;
            PanType                = other?.PanType                ?? 0;
            PanRate                = other?.PanRate                ?? 50;
            PanDepth               = other?.PanDepth               ?? 50;
            PanStepRate            = other?.PanStepRate            ?? 0;
            PanPosition            = other?.PanPosition            ?? 50;
            TremoloRate            = other?.TremoloRate            ?? 85;
            TremoloDepth           = other?.TremoloDepth           ?? 50;
            TremoloLevel           = other?.TremoloLevel           ?? 50;
            SlicerPattern          = other?.SlicerPattern          ?? 0;
            SlicerRate             = other?.SlicerRate             ?? 110;
            SlicerDepth            = other?.SlicerDepth            ?? 100;
            DelayTime              = other?.DelayTime              ?? 200;
            DelayFeedback          = other?.DelayFeedback          ?? 20;
            DelayLevel             = other?.DelayLevel             ?? 50;
            PanningDelayTime       = other?.PanningDelayTime       ?? 200;
            PanningDelayFeedback   = other?.PanningDelayFeedback   ?? 20;
            PanningDelayLevel      = other?.PanningDelayLevel      ?? 50;
            TapeEchoRate           = other?.TapeEchoRate           ?? 50;
            TapeEchoIntensity      = other?.TapeEchoIntensity      ?? 50;
            TapeEchoLevel          = other?.TapeEchoLevel          ?? 50;
            GranularDelayTime      = other?.GranularDelayTime      ?? 50;
            GranularDelayFeedback  = other?.GranularDelayFeedback  ?? 70;
            GranularDelayLevel     = other?.GranularDelayLevel     ?? 50;
            RollTime               = other?.RollTime               ?? 1008;
            RollMode               = other?.RollMode               ?? 2;
            RollFeedback           = other?.RollFeedback           ?? 20;
            RollLevel              = other?.RollLevel              ?? 50;
            ChorusRate             = other?.ChorusRate             ?? 50;
            ChorusDepth            = other?.ChorusDepth            ?? 50;
            ChorusLevel            = other?.ChorusLevel            ?? 50;
            ReverbTime             = other?.ReverbTime             ?? 27;
            ReverbLevel            = other?.ReverbLevel            ?? 50;
            ReverbDryLevel         = other?.ReverbDryLevel         ?? 100;
        }

        public XmlFxSettings Clone() => new XmlFxSettings(this);
    }
}
