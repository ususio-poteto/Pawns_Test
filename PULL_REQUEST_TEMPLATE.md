<!-- I want to review in Japanese. -->
<!-- I want to review in Japanese. -->
<!-- 
.csファイルのコードレビュー時は以下の命名規則をチェックしてください：

**PascalCase（全ての英単語の1文字目を大文字）:**
- public class TestClass{}
- private void TestMethod(){}
- protected int TestField = 0;
- public enum TestEnum{}

**[SerializeField]フィールド: camelCase（最初の英単語を除いた英単語の1文字目を大文字）:**
- [SerializeField] private int testField = 0;

**プライベートフィールド: _camelCase（アンダーバーの後にcamelCase）:**
- private int _testField = 0;
- private string _testString = "test";

**ローカル変数・仮引数: camelCase（最初の英単語を除いた英単語の1文字目を大文字）:**
- private void Sum(int firstNumber, int secondNumber)
- var sumNumber = firstNumber + secondNumber;

**定数: UPPER_SNAKE_CASE（全て大文字で英単語ごとにアンダーバーで区切る）:**
- private const int TEST_CONSTANT = 0;

**インターフェース: IPascalCase（大文字アイの後にPascalCase）:**
- public interface ITestInterface(){}
-->
## 要件
xxxの改修をしました。
## テスト項目
- [x] xxxxxx

## レビュー希望日
mm/dd(曜日) までにレビューお願いします！

## レビューに関して
レビューする際には、以下のprefix(接頭辞)を付けましょう。
<!-- for GitHub Copilot review rule -->
[must] → かならず変更してね  
[imo] → 自分の意見だとこうだけど修正必須ではないよ(in my opinion)  
[nits] → ささいな指摘(nitpick) 
[ask] → 質問  
[fyi] → 参考情報
<!-- for GitHub Copilot review  rule-->

## PRのルール
- まずはDraftでPRを作成する。
- レビューに出せる状態になったらOpenにする。（レビュワーがランダムにアサインされます）
- レビューなしでのmainブランチへのマージは原則禁止
