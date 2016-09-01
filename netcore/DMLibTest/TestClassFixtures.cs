﻿using DMLibTest.Cases;
using System;

// when test class T implements Xunit.IClassFixture<C>, C's ctor is called once, before
// the first test in T runs, and C.Dispose is called once, after the last test in T runs
namespace DMLibTest
{
    public class AccessConditionTestFixture : IDisposable
    {
        public AccessConditionTestFixture()
        {
            AccessConditionTest.MyClassInitialize(null);
        }

        public void Dispose()
        {
            AccessConditionTest.MyClassCleanup();
        }
    }

    public class AllTransferDirectionFixture : IDisposable
    {
        public AllTransferDirectionFixture()
        {
            AllTransferDirectionTest.MyClassInitialize(null);
        }
        public void Dispose()
        {
            AllTransferDirectionTest.MyClassCleanup();
        }
    }

    public class BigFileTestFixture : IDisposable
    {
        public BigFileTestFixture()
        {
            BigFileTest.MyClassInitialize(null);
        }

        public void Dispose()
        {
            BigFileTest.MyClassCleanup();
        }
    }

    public class BVTFixture : IDisposable
    {
        public BVTFixture()
        {
            BVT.MyClassInitialize(null);
        }

        public void Dispose()
        {
            BVT.MyClassCleanup();
        }
    }

    public class CheckContentMD5TestFixture : IDisposable
    {
        public CheckContentMD5TestFixture()
        {
            CheckContentMD5Test.MyClassInitialize(null);
        }

        public void Dispose()
        {
            CheckContentMD5Test.MyClassCleanup();
        }
    }

    public class MetadataTestFixture : IDisposable
    {
        public MetadataTestFixture()
        {
            MetadataTest.MyClassInitialize(null);
        }

        public void Dispose()
        {
            MetadataTest.MyClassCleanup();
        }
    }

    public class OverwriteTestFixture : IDisposable
    {
        public OverwriteTestFixture()
        {
            OverwriteTest.MyClassInitialize(null);
        }

        public void Dispose()
        {
            OverwriteTest.MyClassCleanup();
        }
    }

    public class ProgressHandlerTestFixture : IDisposable
    {
        public ProgressHandlerTestFixture()
        {
            ProgressHandlerTest.MyClassInitialize(null);
        }

        public void Dispose()
        {
            ProgressHandlerTest.MyClassCleanup();
        }
    }

    public class ResumeTestFixture : IDisposable
    {
        public ResumeTestFixture()
        {
            ResumeTest.MyClassInitialize(null);
        }

        public void Dispose()
        {
            ResumeTest.MyClassCleanup();
        }
    }

    public class SearchPatternTestFixture : IDisposable
    {
        public SearchPatternTestFixture()
        {
            SearchPatternTest.MyClassInitialize(null);
        }

        public void Dispose()
        {
            SearchPatternTest.MyClassCleanup();
        }
    }

    public class SetContentTypeTestFixture : IDisposable
    {
        public SetContentTypeTestFixture()
        {
            SetContentTypeTest.MyClassInitialize(null);
        }

        public void Dispose()
        {
            SetContentTypeTest.MyClassCleanup();
        }
    }

    public class SnapshotTestFixture : IDisposable
    {
        public SnapshotTestFixture()
        {
            SnapshotTest.MyClassInitialize(null);
        }

        public void Dispose()
        {
            SnapshotTest.MyClassCleanup();
        }
    }

    public class UnsupportedDirectionTestFixture : IDisposable
    {
        public UnsupportedDirectionTestFixture()
        {
            UnsupportedDirectionTest.MyClassInitialize(null);
        }

        public void Dispose()
        {
            UnsupportedDirectionTest.MyClassCleanup();
        }
    }
}
