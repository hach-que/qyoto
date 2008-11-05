PROJECT(qttest-sharp)

IF (NOT QT4_FOUND)
	FIND_PACKAGE(Qt4 REQUIRED)
ENDIF (NOT QT4_FOUND)

SET(SRC_CPP src/qttest.cpp src/qttesthandlers.cpp)

SET(SRC_CS src/QtTest.cs
	src/AssemblyInfo.cs
	qttest/*.cs)

INCLUDE_DIRECTORIES(${CMAKE_SOURCE_DIR}/smoke 
	${CMAKE_CURRENT_SOURCE_DIR}/../qyoto/src ${QT_INCLUDES})
LINK_DIRECTORIES (${LIBRARY_OUTPUT_PATH})
ADD_LIBRARY(qttest-sharp MODULE ${SRC_CPP})
TARGET_LINK_LIBRARIES(qttest-sharp smokeqt smokeqttest qyotoshared ${QT_QTCORE_LIBRARY} ${QT_QTGUI_LIBRARY})

SET(CS_FLAGS -r:${LIBRARY_OUTPUT_PATH}/qt-dotnet.dll -warn:0 -keyfile:${KEYFILE})
ADD_CS_LIBRARY(qttest "${SRC_CS}" ALL)
ADD_DEPENDENCIES(qttest-sharp smokeqttest)

INSTALL(TARGETS qttest-sharp LIBRARY DESTINATION ${LIB_INSTALL_DIR})
INSTALL_GAC(qttest)