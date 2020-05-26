namespace Ryujinx.Graphics.GAL
{
    public struct Capabilities
    {
        public bool SupportsAstcCompression          { get; }
        public bool SupportsNonConstantTextureOffset { get; }
        public bool SupportsViewportSwizzle          { get; }

        public int   MaximumComputeSharedMemorySize { get; }
        public float MaximumSupportedAnisotropy     { get; }
        public int   StorageBufferOffsetAlignment   { get; }

        public Capabilities(
            bool  supportsAstcCompression,
            bool  supportsNonConstantTextureOffset,
            bool  supportsViewportSwizzle,
            int   maximumComputeSharedMemorySize,
            float maximumSupportedAnisotropy,
            int   storageBufferOffsetAlignment)
        {
            SupportsAstcCompression          = supportsAstcCompression;
            SupportsNonConstantTextureOffset = supportsNonConstantTextureOffset;
            SupportsViewportSwizzle          = supportsViewportSwizzle;
            MaximumComputeSharedMemorySize   = maximumComputeSharedMemorySize;
            MaximumSupportedAnisotropy       = maximumSupportedAnisotropy;
            StorageBufferOffsetAlignment     = storageBufferOffsetAlignment;
        }
    }
}