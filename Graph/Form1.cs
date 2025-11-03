using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;

namespace Graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 1. 기본 스타일 설정
            scintilla1.StyleResetDefault();
            // 💡 한글 가독성이 높은 코딩 전용 폰트 'D2Coding' 적용
            // (폰트가 설치되어 있어야 합니다.)
            scintilla1.Styles[Style.Default].Font = "D2Coding";
            scintilla1.Styles[Style.Default].Size = 11;
            scintilla1.StyleClearAll();
            // 💡 폰트 품질 설정: ClearType 적용 (LcdOptimized)
            scintilla1.FontQuality = FontQuality.LcdOptimized;

            // 2. Lexer (언어 문법 분석기) 설정: C++
            scintilla1.Lexer = Lexer.Cpp;

            // 3. 행 번호(Margin) 설정
            const int lineNumberMargin = 0;

            // 행 번호 마진을 숫자로 설정하고 너비를 지정
            scintilla1.Margins[lineNumberMargin].Type = MarginType.Number;
            scintilla1.Margins[lineNumberMargin].Width = 35;

            // 4. 구문 강조를 위한 키워드 설정 (선택 사항)
            // 0번 키워드 그룹에 C++ 기본 키워드 설정
            scintilla1.SetKeywords(0,
                "abstract as base break case catch checked continue default delegate do else event explicit extern false finally fixed for foreach goto if implicit in interface internal is lock namespace new null object operator out override params private protected public readonly ref return sealed sizeof "
            );

            // 5. 스타일링: 키워드 색상 변경
            scintilla1.Styles[Style.Cpp.Word].ForeColor = Color.Blue;
            scintilla1.Styles[Style.Cpp.Comment].ForeColor = Color.Green;
            scintilla1.Styles[Style.Cpp.String].ForeColor = Color.Maroon;

            // 6. 탭과 자동 들여쓰기 설정
            scintilla1.UseTabs = true;
            scintilla1.TabWidth = 4;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 파일FToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 상태표시줄ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 정보AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Visible = true;
        }
    }
}
