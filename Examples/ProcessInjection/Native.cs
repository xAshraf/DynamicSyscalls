﻿using System;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace ProcessInjection
{
    internal class Native
    {

        public const uint STATUS_SUCCESS = 0;
        public const uint STATUS_INFO_LENGTH_MISMATCH = 0xC0000004;
        public const uint ERROR_INSUFFICIENT_BUFFER = 0x0000007A;
        public const uint SystemProcessInformation = 0x05;
        public static uint THREAD_ALL_ACCESS = 0x1FFFFF;
        public static uint VirtualMemoryWrite = 0x00000020;
        public static uint VirtualMemoryOperation = 0x00000008;
        public const uint SET_CONTEXT = 0x0010;
        public const uint MEM_COMMIT = 0x00001000;
        public const uint MEM_RESERVE = 0x00002000;
        public const uint ReadWrite = 0x04;
        public const uint ExecuteRead = 0x20;

        public delegate uint NtOpenProcess(ref IntPtr ThreadProcess, uint AccessMask, ref OBJECT_ATTRIBUTES ObjectAttributes, ref CLIENT_ID ClientId);
        public delegate uint NtOpenThread(ref IntPtr ThreadHandle, uint AccessMask, ref OBJECT_ATTRIBUTES ObjectAttributes, ref CLIENT_ID ClientId);
        public delegate uint NtClose(IntPtr Handle);
        public delegate uint NtWriteVirtualMemory(IntPtr ProcessHandle, IntPtr BaseAddress, byte[] Buffer, int NumberOfBytesToWrite, ref uint NumberOfBytesWritten);
        public delegate uint NtAllocateVirtualMemory(IntPtr ProcessHandle, ref IntPtr BaseAddress, uint ZeroBits, ref int RegionSize, uint AllocationType, uint Protect);
        public delegate uint NtProtectVirtualMemory(IntPtr ProcessHandle, ref IntPtr BaseAddress, ref int NumberOfBytesToProtect, uint NewAccessProtection, out uint OldAccessProtection);
        public delegate uint NtQueueApcThread(IntPtr ThreadHandle, IntPtr ApcRoutine, uint ApcRoutineContext, IntPtr ApcStatusBlock, int ApcReserved);
        public delegate uint NtQuerySystemInformation(uint SystemInformationClass, IntPtr SystemInformation, uint SystemInformationLength, out uint ReturnLength);

        



    }
}
