// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License



namespace UnityEditor
{
    class SceneViewPickingShortcutContext : SceneViewMotion.SceneViewContext
    {
        public override bool active => ViewHasFocus && Tools.current != Tool.View;
    }
}
