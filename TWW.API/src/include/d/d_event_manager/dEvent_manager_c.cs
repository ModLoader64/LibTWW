//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class dEvent_manager_c {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        // public dEvDtBase_c mList {get => this._mList(); set => this._mList(value);}//;
        
        public u32 mCameraPlay {get => this._mCameraPlay(); set => this._mCameraPlay(value);}//;
        
        public dEvent_exception_c mException {get => this._mException(); set => this._mException(value);}//;
        
        public cXyz mGoal {get => this._mGoal(); set => this._mGoal(value);}//;
        
        // public dEvDtFlag_c mFlag {get => this._mFlag(); set => this._mFlag(value);}//;
        
        public dEvent_manager_c(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x0; // DEADBEEF TODO: Fix Addr
        }
        
/*        private dEvDtBase_c _mList() {
            return new dEvDtBase_c(this.pointer + 0x000);
        }
        
        private void _mList(dEvDtBase_c value) {
        }
        */
        private u32 _mCameraPlay() {
            return Memory.RAM.ReadU32(this.pointer + 0x020);
        }
        
        private void _mCameraPlay(u32 value) {
            Memory.RAM.WriteU32(this.pointer + 0x020, value);
        }
        
        private dEvent_exception_c _mException() {
            return new dEvent_exception_c(this.pointer + 0x024);
        }
        
        private void _mException(dEvent_exception_c value) {
        }
        
        private cXyz _mGoal() {
            return new cXyz(this.pointer + 0x030);
        }
        
        private void _mGoal(cXyz value) {
        }
/*        
        private dEvDtFlag_c _mFlag() {
            return new dEvDtFlag_c(this.pointer + 0x03C);
        }
        
        private void _mFlag(dEvDtFlag_c value) {
        }*/
    }
}
