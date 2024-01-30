namespace WW.API
{
    public class base_process_class
    {
        [System.Text.Json.Serialization.JsonIgnore()]
        public u32 pointer;

        public base_process_class(u32 pointer)
        {
            this.pointer = pointer;
        }

        /* 0x00 */
        public u32 mBsType;
        /* 0x04 */
        public u32 mBsPcId;
        /* 0x08 */
        public s16 mProcName;
        /* 0x0A */
        public s8 mUnk0;
        /* 0x0B */
        public u8 mPauseFlag;
        /* 0x0C */
        public s8 mInitState;
        /* 0x0D */
        public s8 mCreateResult;
        /* 0x0E */
        public s16 mProfName;
        /* 0x10 */
        public process_profile_definition mpProf;
        /* 0x14 */
        public create_request mpCtRq;
        /* 0x18 */
        public layer_management_tag_class mLyTg;
        /* 0x34 */
        public line_tag mLnTg;
        /* 0x4C */
        public delete_tag_class mDtTg;
        /* 0x68 */
        public process_priority_class mPi;
        /* 0xA8 */
        public process_method_class mpPcMtd;
        /* 0xAC */
        public int mpUserData;
        /* 0xB0 */
        public u32 mParameters;
        /* 0xB4 */
        public u32 mSubType;

    }

    public class process_priority_class
    {
        public u32 pointer;

        public process_priority_class(u32 pointer)
        {
            this.pointer = pointer;
        }
        /* 0x00 */
        public create_tag_class mBase;
        /* 0x14 */
        public process_method_tag_class mMtdTag;
        /* 0x30 */
        public process_priority_queue_info mInfoQ;
        /* 0x38 */
        public process_priority_queue_info mInfoCurr;
    }

    public class process_priority_queue_info
    {
        public u32 pointer;

        public process_priority_queue_info(u32 pointer)
        {
            this.pointer = pointer;
        }
        /* 0x00 */
        public u32 mLayer;
        /* 0x04 */
        public u16 mListID;
        /* 0x06 */
        public u16 mListPrio;
    }

    public class delete_tag_class
    {
        public u32 pointer;

        public delete_tag_class(u32 pointer)
        {
            this.pointer = pointer;
        }
        public create_tag_class mBase;
        public layer_class mpLayer;
        public s16 mTimer;
    }

    public class line_tag
    {
        public u32 pointer;

        public line_tag(u32 pointer)
        {
            this.pointer = pointer;
        }
        /* 0x00 */
        public create_tag_class mBase;

        public s32 mLineListID;
    }

    public class layer_management_tag_class
    {
        public u32 pointer;

        public layer_management_tag_class(u32 pointer)
        {
            this.pointer = pointer;
        }

        public create_tag_class mCreateTag;
        public layer_class mpLayer;
        public u16 mNodeListID;
        public u16 mNodeListIdx;
    }

    public class layer_class
    {
        public u32 pointer;

        public layer_class(u32 pointer)
        {
            this.pointer = pointer;
        }

        /* 0x00 */
        public node_class mNode;
        /* 0x0C */
        public u32 mLayerID;
        /* 0x10 */
        public node_lists_tree_class mNodeListTree;
        /* 0x18 */
        public process_node_class mpPcNode;
        /* 0x1C */
        public node_list_class mCancelList;

        /* 0x28 */
        public s16 mCreatingCount;
        /* 0x2A */
        public s16 mDeletingCount;
    }

    public class process_node_class
    {
        public u32 pointer;

        public process_node_class(u32 pointer)
        {
            this.pointer = pointer;
        }

        /* 0x00 */
        public base_process_class mBase;
        /* 0xB8 */
        public nodedraw_method_class mpNodeMtd;
        /* 0xBC */
        public layer_class mLayer;
        /* 0xE8 */ /* #ARRCOUNT  16 */
        public node_list_class[] mLayerNodeLists;
        /* 0x1A8 */
        public s8 mUnk0;
    }

    public class nodedraw_method_class
    {
        public u32 pointer;

        public nodedraw_method_class(u32 pointer)
        {
            this.pointer = pointer;
        }

        /* 0x00 */
        public process_method_class mBase;
        /* 0x10 */
        public int mpDrawFunc;
    }


    public class node_lists_tree_class
    {
        public u32 pointer;

        public node_lists_tree_class(u32 pointer)
        {
            this.pointer = pointer;
        }

        /* 0x00 */
        public node_list_class mpLists;
        /* 0x0C */
        public int mNumLists;
    }

    public class node_list_class
    {
        public u32 pointer;

        public node_list_class(u32 pointer)
        {
            this.pointer = pointer;
        }

        /* 0x00 */
        public node_class mpHead;
        /* 0x04 */
        public node_class mpTail;
        /* 0x08 */
        public int mSize;
    }

    public class create_request
    {
        [System.Text.Json.Serialization.JsonIgnore()]
        public u32 pointer;

        public create_request(u32 pointer)
        {
            this.pointer = pointer;
        }

        public create_tag mBase;
        public s8 mbIsCreating;
        public s8 mbIsCancelling;
        public process_method_tag_class mMtdTg;
        public create_request_method_class mpCtRqMtd;
        public int mpUnk1;
        public s32 mBsPcId;
        public base_process_class mpRes;
        public layer_class mpLayer;

    }

    public class create_request_method_class
    {
        public u32 pointer;

        public create_request_method_class(u32 pointer)
        {
            this.pointer = pointer;
        }
        public int mpHandler;
        public int mpCancel;
        public int mpDelete;
    }

    public class process_method_tag_class
    {
        public u32 pointer;

        public process_method_tag_class(u32 pointer)
        {
            this.pointer = pointer;
        }
        /* 0x00 */
        public create_tag_class mCreateTag;
        /* 0x11 */
        public int mpFunc;
        /* 0x15 */
        public int mpMthdData;
    }

    public class create_tag
    {
        [System.Text.Json.Serialization.JsonIgnore()]
        public u32 pointer;

        public create_tag(u32 pointer)
        {
            this.pointer = pointer;
        }

        public create_tag_class mBase { get; set; }
    }

    public class create_tag_class
    {
        [System.Text.Json.Serialization.JsonIgnore()]
        public u32 pointer;

        public create_tag_class(u32 pointer)
        {
            this.pointer = pointer;
        }

        /* 0x00 */
        public node_class mpNode;
        /* 0x0C */
        public int mpTagData;
        /* 0x10 */
        public s8 mbIsUse;
    }

    public class node_class
    {
        [System.Text.Json.Serialization.JsonIgnore()]
        public u32 pointer;

        public node_class(u32 pointer)
        {
            this.pointer = pointer;
        }

        public node_class mpPrevNode { get; set; }
        public int mpData { get; set; }
        public node_class mpNextNode { get; set; }
    }

    public class leafdraw_class
    {
        [System.Text.Json.Serialization.JsonIgnore()]
        public u32 pointer;

        public leafdraw_class(u32 pointer)
        {
            this.pointer = pointer;
        }

    }

    public class process_method_class
    {
        [System.Text.Json.Serialization.JsonIgnore()]
        public u32 pointer;

        public process_method_class(u32 pointer)
        {
            this.pointer = pointer;
        }

        public int mpCreateFunc { get; set; }
        public int mpDeleteFunc { get; set; }
        public int mpExecuteFunc { get; set; }
        public int mpIsDeleteFunc { get; set; }

    }

    public class process_profile_definition
    {
        [System.Text.Json.Serialization.JsonIgnore()]
        public u32 pointer;

        public process_profile_definition(u32 pointer)
        {
            this.pointer = pointer;
        }

        /* 0x00 */
        public s32 mLayerID { get; set; }
        /* 0x04 */
        public u16 mListID { get; set; }
        /* 0x06 */
        public u16 mListPrio { get; set; }
        /* 0x08 */
        public s16 mProcName { get; set; }
        /* 0x0C */
        public process_method_class mSubMtd { get; set; } // Subclass methods
        /* 0x10 */
        public s32 mSize { get; set; }
        /* 0x14 */
        public s32 mSizeOther { get; set; }
        /* 0x18 */
        public s32 mParameters { get; set; }

    }
}

