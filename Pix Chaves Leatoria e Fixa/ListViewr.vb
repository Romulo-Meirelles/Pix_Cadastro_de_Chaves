Option Strict On
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Public Class ListViewCustom
    Inherits ListView

    Public Const LVCDI_ITEM = &H0
    Public Const LVCDI_GROUP = &H1
    Public Const LVCDI_ITEMSLIST = &H2

    Public Const LVM_FIRST = &H1000
    Public Const LVM_GETGROUPRECT = (LVM_FIRST + 98)
    Public Const LVM_ENABLEGROUPVIEW = (LVM_FIRST + 157)
    Public Const LVM_SETGROUPINFO = (LVM_FIRST + 147)
    Public Const LVM_GETGROUPINFO = (LVM_FIRST + 149)
    Public Const LVM_REMOVEGROUP = (LVM_FIRST + 150)
    Public Const LVM_MOVEGROUP = (LVM_FIRST + 151)
    Public Const LVM_GETGROUPCOUNT = (LVM_FIRST + 152)
    Public Const LVM_GETGROUPINFOBYINDEX = (LVM_FIRST + 153)
    Public Const LVM_MOVEITEMTOGROUP = (LVM_FIRST + 154)

    Public Const WM_LBUTTONUP = &H202

    <StructLayout(LayoutKind.Sequential)>
    Public Structure NMHDR
        Public hwndFrom As IntPtr
        Public idFrom As IntPtr
        Public code As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Public Structure RECT
        Public left As Integer
        Public top As Integer
        Public right As Integer
        Public bottom As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Public Structure NMCUSTOMDRAW
        Public hdr As NMHDR
        Public dwDrawStage As Integer
        Public hdc As IntPtr
        Public rc As RECT
        Public dwItemSpec As IntPtr
        Public uItemState As UInteger
        Public lItemlParam As IntPtr
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Public Structure NMLVCUSTOMDRAW
        Public nmcd As NMCUSTOMDRAW
        Public clrText As Integer
        Public clrTextBk As Integer
        Public iSubItem As Integer
        Public dwItemType As Integer
        Public clrFace As Integer
        Public iIconEffect As Integer
        Public iIconPhase As Integer
        Public iPartId As Integer
        Public iStateId As Integer
        Public rcText As RECT
        Public uAlign As UInteger
    End Structure

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
    Public Structure LVGROUP
        Public cbSize As UInteger
        Public mask As UInteger
        '<MarshalAs(UnmanagedType.LPTStr)>
        'Public pszHeader As String
        Public pszHeader As IntPtr
        Public cchHeader As Integer
        '<MarshalAs(UnmanagedType.LPTStr)>
        'Public pszFooter As String
        Public pszFooter As IntPtr
        Public cchFooter As Integer
        Public iGroupId As Integer
        Public stateMask As UInteger
        Public state As UInteger
        Public uAlign As UInteger

        '<MarshalAs(UnmanagedType.LPTStr)>
        'Public pszSubtitle As String
        Public pszSubtitle As IntPtr
        Public cchSubtitle As UInteger
        '<MarshalAs(UnmanagedType.LPTStr)>
        'Public pszTask As String
        Public pszTask As IntPtr
        Public cchTask As UInteger
        '<MarshalAs(UnmanagedType.LPTStr)>
        'Public pszDescriptionTop As String
        Public pszDescriptionTop As IntPtr
        Public cchDescriptionTop As UInteger
        '<MarshalAs(UnmanagedType.LPTStr)>
        'Public pszDescriptionBottom As String
        Public pszDescriptionBottom As IntPtr
        Public cchDescriptionBottom As UInteger
        Public iTitleImage As Integer
        Public iExtendedImage As Integer
        Public iFirstItem As Integer
        Public cItems As UInteger
        '<MarshalAs(UnmanagedType.LPTStr)>
        'Public pszSubsetTitle As String
        Public pszSubsetTitle As IntPtr
        Public cchSubsetTitle As UInteger
    End Structure


    <Flags>
    Public Enum CDRF
        CDRF_DODEFAULT = &H0
        CDRF_NEWFONT = &H2
        CDRF_SKIPDEFAULT = &H4
        CDRF_DOERASE = &H8
        CDRF_SKIPPOSTPAINT = &H100
        CDRF_NOTIFYPOSTPAINT = &H10
        CDRF_NOTIFYITEMDRAW = &H20
        CDRF_NOTIFYSUBITEMDRAW = &H20
        CDRF_NOTIFYPOSTERASE = &H40
    End Enum

    <Flags>
    Public Enum CDDS
        CDDS_PREPAINT = &H1
        CDDS_POSTPAINT = &H2
        CDDS_PREERASE = &H3
        CDDS_POSTERASE = &H4
        CDDS_ITEM = &H10000
        CDDS_ITEMPREPAINT = (CDDS_ITEM Or CDDS_PREPAINT)
        CDDS_ITEMPOSTPAINT = (CDDS_ITEM Or CDDS_POSTPAINT)
        CDDS_ITEMPREERASE = (CDDS_ITEM Or CDDS_PREERASE)
        CDDS_ITEMPOSTERASE = (CDDS_ITEM Or CDDS_POSTERASE)
        CDDS_SUBITEM = &H20000
    End Enum

    Public Const LVGF_NONE = &H0
    Public Const LVGF_HEADER = &H1
    Public Const LVGF_FOOTER = &H2
    Public Const LVGF_STATE = &H4
    Public Const LVGF_ALIGN = &H8
    Public Const LVGF_GROUPID = &H10

    Public Const LVGF_SUBTITLE = &H100 'pszSubtitle is valid
    Public Const LVGF_TASK = &H200 'pszTask is valid
    Public Const LVGF_DESCRIPTIONTOP = &H400 'pszDescriptionTop is valid
    Public Const LVGF_DESCRIPTIONBOTTOM = &H800 'pszDescriptionBottom is valid
    Public Const LVGF_TITLEIMAGE = &H1000 'iTitleImage is valid
    Public Const LVGF_EXTENDEDIMAGE = &H2000 'iExtendedImage is valid
    Public Const LVGF_ITEMS = &H4000 'iFirstItem and cItems are valid
    Public Const LVGF_SUBSET = &H8000 'pszSubsetTitle is valid
    Public Const LVGF_SUBSETITEMS = &H10000 'readonly, cItems holds count of items in visible subset, iFirstItem is valid

    Public Const LVGS_NORMAL = &H0
    Public Const LVGS_COLLAPSED = &H1
    Public Const LVGS_HIDDEN = &H2
    Public Const LVGS_NOHEADER = &H4
    Public Const LVGS_COLLAPSIBLE = &H8
    Public Const LVGS_FOCUSED = &H10
    Public Const LVGS_SELECTED = &H20
    Public Const LVGS_SUBSETED = &H40
    Public Const LVGS_SUBSETLINKFOCUSED = &H80

    Public Const LVGA_HEADER_LEFT = &H1
    Public Const LVGA_HEADER_CENTER = &H2
    Public Const LVGA_HEADER_RIGHT = &H4 'Don't forget to validate exclusivity
    Public Const LVGA_FOOTER_LEFT = &H8
    Public Const LVGA_FOOTER_CENTER = &H10
    Public Const LVGA_FOOTER_RIGHT = &H20 'Don't forget to validate exclusivity

    Public Const LVGGR_GROUP = 0 ' Entire expanded group
    Public Const LVGGR_HEADER = 1  ' Header only (collapsed group)
    Public Const LVGGR_LABEL = 2  ' Label only
    Public Const LVGGR_SUBSETLINK = 3  'subset link only

    <DllImport("User32.dll", EntryPoint:="SendMessageW", SetLastError:=True)>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByRef lParam As IntPtr) As Integer
    End Function

    <DllImport("User32.dll", EntryPoint:="SendMessageW", SetLastError:=True)>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByRef lParam As LVGROUP) As Integer
    End Function

    <DllImport("User32.dll", EntryPoint:="SendMessageW", SetLastError:=True)>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByRef lParam As RECT) As Integer
    End Function

    <DllImport("User32.dll", EntryPoint:="PostMessageW", SetLastError:=True)>
    Public Shared Function PostMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByRef lParam As IntPtr) As Integer
    End Function

    Public Function SetGroupInfo(ByVal hWnd As IntPtr, nGroupID As Integer, nSate As UInteger) As Integer
        Dim lvg As LVGROUP = New LVGROUP()
        lvg.cbSize = CUInt(Marshal.SizeOf(lvg))
        lvg.mask = LVGF_STATE Or LVGF_GROUPID Or LVGF_HEADER
        ' for test
        Dim nRet2 As Integer = SendMessage(hWnd, LVM_GETGROUPINFO, nGroupID, lvg)

        lvg.state = nSate
        lvg.mask = LVGF_STATE
        nRet2 = SendMessage(hWnd, LVM_SETGROUPINFO, nGroupID, lvg)
    End Function

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_REFLECT + WM_NOFITY Then
            Dim pnmhdr = CType(m.GetLParam(GetType(NMHDR)), NMHDR)
            If pnmhdr.code = NM_CUSTOMDRAW Then
                Dim pnmlv = CType(m.GetLParam(GetType(NMLVCUSTOMDRAW)), NMLVCUSTOMDRAW)
                Select Case pnmlv.nmcd.dwDrawStage
                    Case CDDS.CDDS_PREPAINT
                        If (pnmlv.dwItemType = LVCDI_GROUP) Then
                            Dim rectHeader As RECT = New RECT()
                            rectHeader.top = LVGGR_HEADER
                            Dim nItem As Integer = CInt(pnmlv.nmcd.dwItemSpec)
                            If (nItem = 0) Then
                                Dim nRet As Integer = SendMessage(m.HWnd, LVM_GETGROUPRECT, nItem, rectHeader)
                                Using g As Graphics = Graphics.FromHdc(pnmlv.nmcd.hdc)
                                    Dim rect As New Rectangle(rectHeader.left, rectHeader.top, rectHeader.right - rectHeader.left, rectHeader.bottom - rectHeader.top)
                                    Dim linGrBrush As New LinearGradientBrush(New System.Drawing.Point(0, 0), New System.Drawing.Point(rectHeader.right, rectHeader.bottom), Color.Blue, Color.LightCyan)
                                    g.FillRectangle(linGrBrush, rect)

                                    Dim lvg As LVGROUP = New LVGROUP()
                                    lvg.cbSize = CUInt(Marshal.SizeOf(lvg))
                                    lvg.mask = LVGF_STATE Or LVGF_GROUPID Or LVGF_HEADER
                                    Dim nRet2 As Integer = SendMessage(m.HWnd, LVM_GETGROUPINFO, nItem, lvg)
                                    Dim sText = Marshal.PtrToStringUni(lvg.pszHeader)

                                    rect.Offset(10, 2)
                                    Using drawFont As New System.Drawing.Font("Times New Roman", 10)
                                        Using drawBrush As New SolidBrush(Color.Yellow)
                                            g.DrawString(sText, drawFont, drawBrush, rect)
                                        End Using
                                    End Using
                                End Using
                                m.Result = New IntPtr(CDRF.CDRF_SKIPDEFAULT)
                            End If
                        Else
                            m.Result = New IntPtr(CDRF.CDRF_NOTIFYITEMDRAW)
                        End If
                    Case CDDS.CDDS_ITEMPREPAINT
                        m.Result = New IntPtr(CDRF.CDRF_NOTIFYSUBITEMDRAW Or CDRF.CDRF_NOTIFYPOSTPAINT)
                    Case CDDS.CDDS_ITEMPOSTPAINT
                End Select
            End If
            Return
        ElseIf m.Msg = WM_LBUTTONUP Then
            MyBase.DefWndProc(m)
        Else
            MyBase.WndProc(m)
        End If
    End Sub

    Private Const NM_FIRST As Integer = 0
    Private Const NM_CLICK As Integer = NM_FIRST - 2
    Private Const NM_CUSTOMDRAW As Integer = NM_FIRST - 12
    Private Const WM_REFLECT As Integer = &H2000
    Private Const WM_NOFITY As Integer = &H4E
End Class
