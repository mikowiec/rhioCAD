#-------------------------------------------------
#
# Project created by QtCreator 2011-05-10T00:25:53
#
#-------------------------------------------------

TARGET = NaroOccCore
TEMPLATE = lib

DEFINES += NAROOCCCORE_LIBRARY

SOURCES += \

include(File.List)


HEADERS +=\
    NaroExport.h \
    Export_Import.h

win32 {
        message ("Building for Win32")
        DEFINES += WNT
        #To prevent external manifests under VS 2005
        CONFIG += embed_manifest_dll windows

        include( QtOpenCascadeWin32.pri )
}

unix {
        message ("Building for Linux")
        DEFINES += LIN LININTEL HAVE_CONFIG_H HAVE_IOSTREAM HAVE_FSTREAM HAVE_LIMITS_H
        include( QtOpenCascadeLinux.pri )

        HARDWARE_PLATFORM = $$system(uname -m)
        contains( HARDWARE_PLATFORM, x86_64 ) {

                # 64-bit Linux
                message ("Adding Linux 64 bits compile flags and definitions")
                DEFINES += _OCC64
                QMAKE_CXXFLAGS += -m64

        } else {
                # 32-bit Linux
        }
}

OTHER_FILES += \
    FileList.pri
