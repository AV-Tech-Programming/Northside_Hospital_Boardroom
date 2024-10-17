//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by CrestronConstruct.
//     Version: 1.3501.16.0
//
//     Project:     NH_Boardroom_TST1080
//     Version:     1.0.0.0
//     Sdk:         CH5:2.11.1
//     Strategy:    Modern
//     IndexOnly:   False
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Crestron.SimplSharp;
using Crestron.SimplSharpPro;
using Crestron.SimplSharpPro.DeviceSupport;
using NH_Boardroom_TST1080;

namespace NH_Boardroom_TST1080.TunerControl
{

    /// <summary>
    /// Allow events by list item and states (feedbacks) to be set by item index.
    /// </summary>
    public partial interface ITunerNumberPadByItem
    {
        /// <summary>
        /// Fires on keypad button presses.  Event carries <see="KeypadEventArgs"/> with KeypadButton property of <see="KeypadButton"/> enum type.
        /// </summary>
        event EventHandler<KeypadEventArgs> Button_PressEvent;
    }


    /// <summary>
    /// Search List
    /// </summary>
    internal partial class TunerNumberPad
    {
        #region CH5 Contract
        /// <inheritdoc/>
        public event EventHandler<KeypadEventArgs> Button_PressEvent;
        private void onButton_Press(IndexedEventArgs eventArgs)
        {
            EventHandler<KeypadEventArgs> handler = Button_PressEvent;
            if (handler != null)
                handler(this, new KeypadEventArgs((SmartObjectEventArgs)eventArgs.SigArgs, (KeypadButton)eventArgs.JoinIndex));
        }


        #endregion
    }

    /// <summary>
    /// Tuner Number Pad
    /// </summary>
    public partial interface ITunerNumberPad : ITunerNumberPadByItem
    {
        object UserObject { get; set; }

        /// <summary>
        /// Event Press1.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> Press1Event;

        /// <summary>
        /// Event Press2.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> Press2Event;

        /// <summary>
        /// Event Press3.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> Press3Event;

        /// <summary>
        /// Event Press4.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> Press4Event;

        /// <summary>
        /// Event Press5.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> Press5Event;

        /// <summary>
        /// Event Press6.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> Press6Event;

        /// <summary>
        /// Event Press7.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> Press7Event;

        /// <summary>
        /// Event Press8.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> Press8Event;

        /// <summary>
        /// Event Press9.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> Press9Event;

        /// <summary>
        /// Event Press0.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> Press0Event;

        /// <summary>
        /// Event PressStar.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> PressStarEvent;

        /// <summary>
        /// Event PressHash.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> PressHashEvent;

        /// <summary>
        /// Event PressExtraButton.Press (from panel to Control System)
        /// </summary>
        event EventHandler<UIEventArgs> PressExtraButtonEvent;
    }

    /// <summary>
    /// Digital callback used in feedback events.
    /// </summary>
    /// <param name="boolInputSig">The <see cref="BoolInputSig"/> joinInfo data.</param>
    /// <param name="tunernumberpad">The <see cref="ITunerNumberPad"/> on which to apply the feedback.</param>
    public delegate void TunerNumberPadBoolInputSigDelegate(BoolInputSig boolInputSig, ITunerNumberPad tunernumberpad);

    /// <summary>
    /// Tuner Number Pad
    /// </summary>
    internal partial class TunerNumberPad : ITunerNumberPad, IDisposable
    {
        #region Standard CH5 Component members

        private ComponentMediator ComponentMediator { get; set; }

        public object UserObject { get; set; }

        /// <summary>
        /// Gets the ControlJoinId a.k.a. SmartObjectId.  This Id identifies the extender symbol.
        /// </summary>
        public uint ControlJoinId { get; private set; }

        private IList<BasicTriListWithSmartObject> _devices;

        /// <summary>
        /// Gets the list of devices.
        /// </summary>
        public IList<BasicTriListWithSmartObject> Devices { get { return _devices; } }

        #endregion

        #region Joins

        private static class Joins
        {
            /// <summary>
            /// Digital signals,
            /// </summary>
            internal static class Booleans
            {
                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: TunerControl.TunerNumberPad.Press1
                /// Press1.Press
                /// </summary>
                public const uint Press1Event = 3;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: TunerControl.TunerNumberPad.Press2
                /// Press2.Press
                /// </summary>
                public const uint Press2Event = 4;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: TunerControl.TunerNumberPad.Press3
                /// Press3.Press
                /// </summary>
                public const uint Press3Event = 5;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: TunerControl.TunerNumberPad.Press4
                /// Press4.Press
                /// </summary>
                public const uint Press4Event = 6;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: TunerControl.TunerNumberPad.Press5
                /// Press5.Press
                /// </summary>
                public const uint Press5Event = 7;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: TunerControl.TunerNumberPad.Press6
                /// Press6.Press
                /// </summary>
                public const uint Press6Event = 8;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: TunerControl.TunerNumberPad.Press7
                /// Press7.Press
                /// </summary>
                public const uint Press7Event = 9;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: TunerControl.TunerNumberPad.Press8
                /// Press8.Press
                /// </summary>
                public const uint Press8Event = 10;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: TunerControl.TunerNumberPad.Press9
                /// Press9.Press
                /// </summary>
                public const uint Press9Event = 11;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: TunerControl.TunerNumberPad.Press0
                /// Press0.Press
                /// </summary>
                public const uint Press0Event = 12;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: TunerControl.TunerNumberPad.PressStar
                /// PressStar.Press
                /// </summary>
                public const uint PressStarEvent = 13;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: TunerControl.TunerNumberPad.PressHash
                /// PressHash.Press
                /// </summary>
                public const uint PressHashEvent = 14;

                /// <summary>
                /// Output or Event digital joinInfo from panel to Control System: TunerControl.TunerNumberPad.PressExtraButton
                /// PressExtraButton.Press
                /// </summary>
                public const uint PressExtraButtonEvent = 15;


            }
        }

        #endregion

        #region Construction and Initialization

        /// <summary>
        /// Initializes a new instance of the <see cref="TunerNumberPad"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        internal TunerNumberPad(ComponentMediator componentMediator, uint controlJoinId, uint? itemCount)
        {
            ComponentMediator = componentMediator;
            Initialize(controlJoinId, itemCount);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TunerNumberPad"/> component class.
        /// </summary>
        /// <param name="componentMediator">The <see cref="ComponentMediator"/> used to instantiate the component.</param>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        internal TunerNumberPad(ComponentMediator componentMediator, uint controlJoinId) : this(componentMediator, controlJoinId, null)
        {
        }

        /// <summary>
        /// Initializes a new instance with default itemCount.
        /// </summary>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        private void Initialize(uint controlJoinId)
        {
            Initialize(controlJoinId, null);
        }

        private Dictionary<string, Indexes> _indexLookup = new Dictionary<string, Indexes>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TunerNumberPad"/> component class.
        /// </summary>
        /// <param name="controlJoinId">The SmartObjectId at which to create the component.</param>
        /// <param name="itemCount">The number of items.</param>
        private void Initialize(uint controlJoinId, uint? itemCount)
        {
            ControlJoinId = controlJoinId; 
 
            _devices = new List<BasicTriListWithSmartObject>(); 
 
            ComponentMediator.ConfigureBooleanItemEvent(controlJoinId, Joins.Booleans.Press1Event, GetIndexes, onButton_Press);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press1Event, onPress1);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press2Event, onPress2);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press3Event, onPress3);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press4Event, onPress4);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press5Event, onPress5);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press6Event, onPress6);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press7Event, onPress7);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press8Event, onPress8);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press9Event, onPress9);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.Press0Event, onPress0);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.PressStarEvent, onPressStar);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.PressHashEvent, onPressHash);
            ComponentMediator.ConfigureBooleanEvent(controlJoinId, Joins.Booleans.PressExtraButtonEvent, onPressExtraButton);
        }

        /// <summary>
        /// Get the offset when using indexed complex components.
        /// </summary>
        /// <param name="controlJoinId">The SmartObjectId of the component.</param>
        /// <param name="join">The join offset.</param>
        /// <param name="eSigType">The join data type.</param>
        private Indexes GetIndexes(uint controlJoinId, uint join, eSigType eSigType)
        {
            if (controlJoinId == ControlJoinId &&
                join >= Joins.Booleans.Press1Event &&
                join <= Joins.Booleans.PressExtraButtonEvent)
            {
                return new Indexes(0, (ushort)(join - Joins.Booleans.Press1Event), false);
            }

            return new Indexes(0, 0, true);
        }

        public void AddDevice(BasicTriListWithSmartObject device)
        {
            Devices.Add(device);
            ComponentMediator.HookSmartObjectEvents(device.SmartObjects[ControlJoinId]);
        }

        public void RemoveDevice(BasicTriListWithSmartObject device)
        {
            Devices.Remove(device);
            ComponentMediator.UnHookSmartObjectEvents(device.SmartObjects[ControlJoinId]);
        }

        #endregion

        #region CH5 Contract

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> Press1Event;
        private void onPress1(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press1Event;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> Press2Event;
        private void onPress2(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press2Event;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> Press3Event;
        private void onPress3(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press3Event;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> Press4Event;
        private void onPress4(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press4Event;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> Press5Event;
        private void onPress5(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press5Event;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> Press6Event;
        private void onPress6(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press6Event;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> Press7Event;
        private void onPress7(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press7Event;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> Press8Event;
        private void onPress8(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press8Event;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> Press9Event;
        private void onPress9(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press9Event;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> Press0Event;
        private void onPress0(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = Press0Event;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> PressStarEvent;
        private void onPressStar(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = PressStarEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> PressHashEvent;
        private void onPressHash(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = PressHashEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }

        /// <inheritdoc/>
        public event EventHandler<UIEventArgs> PressExtraButtonEvent;
        private void onPressExtraButton(SmartObjectEventArgs eventArgs)
        {
            EventHandler<UIEventArgs> handler = PressExtraButtonEvent;
            if (handler != null)
                handler(this, UIEventArgs.CreateEventArgs(eventArgs));
        }


        #endregion

        #region Overrides

        public override int GetHashCode()
        {
            return (int)ControlJoinId;
        }

        public override string ToString()
        {
            return string.Format("Contract: {0} Component: {1} HashCode: {2} {3}", "TunerNumberPad", GetType().Name, GetHashCode(), UserObject != null ? "UserObject: " + UserObject : null);
        }

        #endregion

        #region IDisposable

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

            Button_PressEvent = null;
            Press1Event = null;
            Press2Event = null;
            Press3Event = null;
            Press4Event = null;
            Press5Event = null;
            Press6Event = null;
            Press7Event = null;
            Press8Event = null;
            Press9Event = null;
            Press0Event = null;
            PressStarEvent = null;
            PressHashEvent = null;
            PressExtraButtonEvent = null;
        }

        #endregion
    }
}
