//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class dPlace_name_c {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        //public J2DScreen scrn {get => this._scrn(); set => this._scrn(value);}//;
        
        public fopMsgM_pane_class pane {get => this._pane(); set => this._pane(value);}//;
        
        public dPlace_name_c(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x0; // DEADBEEF TODO: Fix Addr
        }
        
/*        private J2DScreen _scrn() {
            return new J2DScreen(this.pointer + 0x04);
        }
        
        private void _scrn(J2DScreen value) {
        }*/
        
        private fopMsgM_pane_class _pane() {
            return new fopMsgM_pane_class(this.pointer + 0x08);
        }
        
        private void _pane(fopMsgM_pane_class value) {
        }
    }
}