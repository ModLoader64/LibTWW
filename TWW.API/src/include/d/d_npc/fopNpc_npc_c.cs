//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class fopNpc_npc_c {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public dNpc_JntCtrl_c m_jnt {get => this._m_jnt(); set => this._m_jnt(value);}//;
        
        public dNpc_EventCut_c mEventCut {get => this._mEventCut(); set => this._mEventCut(value);}//;
        
        /*public mDoExt_McaMorf mpMcaMorf {get => this._mpMcaMorf(); set => this._mpMcaMorf(value);}//;
        
        public dBgS_ObjAcch mObjAcch {get => this._mObjAcch(); set => this._mObjAcch(value);}//;
        
        public dBgS_AcchCir mAcchCir {get => this._mAcchCir(); set => this._mAcchCir(value);}//;
        
        public dCcD_Stts mStts {get => this._mStts(); set => this._mStts(value);}//;
        
        public dCcD_Cyl mCyl {get => this._mCyl(); set => this._mCyl(value);}//;*/
        
        public u32 mCurrMsgNo {get => this._mCurrMsgNo(); set => this._mCurrMsgNo(value);}//;
        
        public u32 mEndMsgNo {get => this._mEndMsgNo(); set => this._mEndMsgNo(value);}//;
        
        public u32 mCurrMsgBsPcId {get => this._mCurrMsgBsPcId(); set => this._mCurrMsgBsPcId(value);}//;
        
        public msg_class mpCurrMsg {get => this._mpCurrMsg(); set => this._mpCurrMsg(value);}//;
        
        public u8[] pad_0x6B4 {get => this._pad_0x6B4(); set => this._pad_0x6B4(value);}//;
        
        public fopNpc_npc_c(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x0; // DEADBEEF TODO: Fix Addr
        }
        
        private dNpc_JntCtrl_c _m_jnt() {
            return new dNpc_JntCtrl_c(this.pointer + 0x290);
        }
        
        private void _m_jnt(dNpc_JntCtrl_c value) {
        }
        
        private dNpc_EventCut_c _mEventCut() {
            return new dNpc_EventCut_c(this.pointer + 0x2C4);
        }
        
        private void _mEventCut(dNpc_EventCut_c value) {
        }
        
       /* private mDoExt_McaMorf _mpMcaMorf() {
            return new mDoExt_McaMorf(this.pointer + 0x330);
        }
        
        private void _mpMcaMorf(mDoExt_McaMorf value) {
        }
        
        private dBgS_ObjAcch _mObjAcch() {
            return new dBgS_ObjAcch(this.pointer + 0x334);
        }
        
        private void _mObjAcch(dBgS_ObjAcch value) {
        }
        
        private dBgS_AcchCir _mAcchCir() {
            return new dBgS_AcchCir(this.pointer + 0x4F8);
        }
        
        private void _mAcchCir(dBgS_AcchCir value) {
        }
        
        private dCcD_Stts _mStts() {
            return new dCcD_Stts(this.pointer + 0x538);
        }
        
        private void _mStts(dCcD_Stts value) {
        }
        
        private dCcD_Cyl _mCyl() {
            return new dCcD_Cyl(this.pointer + 0x574);
        }
        
        private void _mCyl(dCcD_Cyl value) {
        }
        */
        private u32 _mCurrMsgNo() {
            return Memory.RAM.ReadU32(this.pointer + 0x6A4);
        }
        
        private void _mCurrMsgNo(u32 value) {
            Memory.RAM.WriteU32(this.pointer + 0x6A4, value);
        }
        
        private u32 _mEndMsgNo() {
            return Memory.RAM.ReadU32(this.pointer + 0x6A8);
        }
        
        private void _mEndMsgNo(u32 value) {
            Memory.RAM.WriteU32(this.pointer + 0x6A8, value);
        }
        
        private u32 _mCurrMsgBsPcId() {
            return Memory.RAM.ReadU32(this.pointer + 0x6AC);
        }
        
        private void _mCurrMsgBsPcId(u32 value) {
            Memory.RAM.WriteU32(this.pointer + 0x6AC, value);
        }
        
        private msg_class _mpCurrMsg() {
            return new msg_class(this.pointer + 0x6B0);
        }
        
        private void _mpCurrMsg(msg_class value) {
        }
        
        // #ARRCOUNT 12
        private u8[] _pad_0x6B4() {
            u8[] bytes = new u8[12]; for(u32 i = 0; i < 12; i++){bytes[i] = Memory.RAM.ReadU8(this.pointer + 0x6B4 + (i * 1));} return bytes;
        }
        
        private void _pad_0x6B4(u8[] value) {
            for(u32 i = 0; i < 12; i++){Memory.RAM.WriteU8(this.pointer + 0x6B4 + (i * 1), value[i]);}
        }
    }
}
