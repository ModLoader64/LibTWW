//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class dNpc_EventCut_c {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        //public char mpEvtStaffName {get => this._mpEvtStaffName(); set => this._mpEvtStaffName(value);}//;
        
        public u32 mEvtStaffId {get => this._mEvtStaffId(); set => this._mEvtStaffId(value);}//;
        
        public fopAc_ac_c mpActor {get => this._mpActor(); set => this._mpActor(value);}//;
        
        public fopNpc_npc_c mpTalkActor {get => this._mpTalkActor(); set => this._mpTalkActor(value);}//;
        
        public u32 mCurActIdx {get => this._mCurActIdx(); set => this._mCurActIdx(value);}//;
        
        public u32 field_0x14 {get => this._field_0x14(); set => this._field_0x14(value);}//;
        
        public u32 mTimer {get => this._mTimer(); set => this._mTimer(value);}//;
        
        //public char mpActorName {get => this._mpActorName(); set => this._mpActorName(value);}//;
        
        public u32 field_0x20 {get => this._field_0x20(); set => this._field_0x20(value);}//;
        
        public s32 mSetId {get => this._mSetId(); set => this._mSetId(value);}//;
        
        public cXyz mOffsetPos {get => this._mOffsetPos(); set => this._mOffsetPos(value);}//;
        
        public cXyz mTargetActorPos {get => this._mTargetActorPos(); set => this._mTargetActorPos(value);}//;
        
        public fopAc_ac_c mpTargetActor {get => this._mpTargetActor(); set => this._mpTargetActor(value);}//;
        
        public s16 field_0x44 {get => this._field_0x44(); set => this._field_0x44(value);}//;
        
        public f32 mSpeed {get => this._mSpeed(); set => this._mSpeed(value);}//;
        
        public f32 pDelDistance {get => this._pDelDistance(); set => this._pDelDistance(value);}//;
        
        public s16 mAddAngle {get => this._mAddAngle(); set => this._mAddAngle(value);}//;
        
        public u8 field_0x52 {get => this._field_0x52(); set => this._field_0x52(value);}//;
        
        public cXyz mPos {get => this._mPos(); set => this._mPos(value);}//;
        
        public u8 mbAttention {get => this._mbAttention(); set => this._mbAttention(value);}//;
        
        public u8 mbNoTurn {get => this._mbNoTurn(); set => this._mbNoTurn(value);}//;
        
        public s16 mTurnSpeed {get => this._mTurnSpeed(); set => this._mTurnSpeed(value);}//;
        
        public u32 mTurnType {get => this._mTurnType(); set => this._mTurnType(value);}//;
        
        public u8 field_0x68 {get => this._field_0x68(); set => this._field_0x68(value);}//;
        
        //public dPath mPath {get => this._mPath(); set => this._mPath(value);}//;
        
        public u8 field_0x04 {get => this._field_0x04(); set => this._field_0x04(value);}//;
        
        public u8 mCurrPointIndex {get => this._mCurrPointIndex(); set => this._mCurrPointIndex(value);}//;
        
        public u8 mbGoingForwards {get => this._mbGoingForwards(); set => this._mbGoingForwards(value);}//;
        
        public u8 field_0x07 {get => this._field_0x07(); set => this._field_0x07(value);}//;
        
        public dNpc_EventCut_c(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x0; // DEADBEEF TODO: Fix Addr
        }
        
        /*private char _mpEvtStaffName() {
            return Memory.RAM.ReadU8(this.pointer + 0x00);
        }
        
        private void _mpEvtStaffName(char value) {
            Memory.RAM.WriteU8(this.pointer + 0x00, value);
        }*/
        
        private u32 _mEvtStaffId() {
            return Memory.RAM.ReadU32(this.pointer + 0x04);
        }
        
        private void _mEvtStaffId(u32 value) {
            Memory.RAM.WriteU32(this.pointer + 0x04, value);
        }
        
        private fopAc_ac_c _mpActor() {
            return new fopAc_ac_c(this.pointer + 0x08);
        }
        
        private void _mpActor(fopAc_ac_c value) {
        }
        
        private fopNpc_npc_c _mpTalkActor() {
            return new fopNpc_npc_c(this.pointer + 0x0C);
        }
        
        private void _mpTalkActor(fopNpc_npc_c value) {
        }
        
        private u32 _mCurActIdx() {
            return Memory.RAM.ReadU32(this.pointer + 0x10);
        }
        
        private void _mCurActIdx(u32 value) {
            Memory.RAM.WriteU32(this.pointer + 0x10, value);
        }
        
        private u32 _field_0x14() {
            return Memory.RAM.ReadU32(this.pointer + 0x14);
        }
        
        private void _field_0x14(u32 value) {
            Memory.RAM.WriteU32(this.pointer + 0x14, value);
        }
        
        private u32 _mTimer() {
            return Memory.RAM.ReadU32(this.pointer + 0x18);
        }
        
        private void _mTimer(u32 value) {
            Memory.RAM.WriteU32(this.pointer + 0x18, value);
        }
        
       /* private char _mpActorName() {
            return Memory.RAM.ReadU8(this.pointer + 0x1C);
        }
        
        private void _mpActorName(char value) {
            Memory.RAM.WriteU8(this.pointer + 0x1C, value);
        }*/
        
        private u32 _field_0x20() {
            return Memory.RAM.ReadU32(this.pointer + 0x20);
        }
        
        private void _field_0x20(u32 value) {
            Memory.RAM.WriteU32(this.pointer + 0x20, value);
        }
        
        private s32 _mSetId() {
            return Memory.RAM.ReadS32(this.pointer + 0x24);
        }
        
        private void _mSetId(s32 value) {
            Memory.RAM.WriteS32(this.pointer + 0x24, value);
        }
        
        private cXyz _mOffsetPos() {
            return new cXyz(this.pointer + 0x28);
        }
        
        private void _mOffsetPos(cXyz value) {
        }
        
        private cXyz _mTargetActorPos() {
            return new cXyz(this.pointer + 0x34);
        }
        
        private void _mTargetActorPos(cXyz value) {
        }
        
        private fopAc_ac_c _mpTargetActor() {
            return new fopAc_ac_c(this.pointer + 0x40);
        }
        
        private void _mpTargetActor(fopAc_ac_c value) {
        }
        
        private s16 _field_0x44() {
            return Memory.RAM.ReadS16(this.pointer + 0x44);
        }
        
        private void _field_0x44(s16 value) {
            Memory.RAM.WriteS16(this.pointer + 0x44, value);
        }
        
        private f32 _mSpeed() {
            return Memory.RAM.ReadF32(this.pointer + 0x48);
        }
        
        private void _mSpeed(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x48, value);
        }
        
        private f32 _pDelDistance() {
            return Memory.RAM.ReadF32(this.pointer + 0x4C);
        }
        
        private void _pDelDistance(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x4C, value);
        }
        
        private s16 _mAddAngle() {
            return Memory.RAM.ReadS16(this.pointer + 0x50);
        }
        
        private void _mAddAngle(s16 value) {
            Memory.RAM.WriteS16(this.pointer + 0x50, value);
        }
        
        private u8 _field_0x52() {
            return Memory.RAM.ReadU8(this.pointer + 0x52);
        }
        
        private void _field_0x52(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x52, value);
        }
        
        private cXyz _mPos() {
            return new cXyz(this.pointer + 0x54);
        }
        
        private void _mPos(cXyz value) {
        }
        
        private u8 _mbAttention() {
            return Memory.RAM.ReadU8(this.pointer + 0x60);
        }
        
        private void _mbAttention(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x60, value);
        }
        
        private u8 _mbNoTurn() {
            return Memory.RAM.ReadU8(this.pointer + 0x61);
        }
        
        private void _mbNoTurn(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x61, value);
        }
        
        private s16 _mTurnSpeed() {
            return Memory.RAM.ReadS16(this.pointer + 0x62);
        }
        
        private void _mTurnSpeed(s16 value) {
            Memory.RAM.WriteS16(this.pointer + 0x62, value);
        }
        
        private u32 _mTurnType() {
            return Memory.RAM.ReadU32(this.pointer + 0x64);
        }
        
        private void _mTurnType(u32 value) {
            Memory.RAM.WriteU32(this.pointer + 0x64, value);
        }
        
        private u8 _field_0x68() {
            return Memory.RAM.ReadU8(this.pointer + 0x68);
        }
        
        private void _field_0x68(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x68, value);
        }
        
        /*private dPath _mPath() {
            return new dPath(this.pointer + 0x00);
        }
        
        private void _mPath(dPath value) {
        }*/
        
        private u8 _field_0x04() {
            return Memory.RAM.ReadU8(this.pointer + 0x04);
        }
        
        private void _field_0x04(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x04, value);
        }
        
        private u8 _mCurrPointIndex() {
            return Memory.RAM.ReadU8(this.pointer + 0x05);
        }
        
        private void _mCurrPointIndex(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x05, value);
        }
        
        private u8 _mbGoingForwards() {
            return Memory.RAM.ReadU8(this.pointer + 0x06);
        }
        
        private void _mbGoingForwards(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x06, value);
        }
        
        private u8 _field_0x07() {
            return Memory.RAM.ReadU8(this.pointer + 0x07);
        }
        
        private void _field_0x07(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x07, value);
        }
    }
}
