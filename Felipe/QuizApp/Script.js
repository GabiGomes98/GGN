const question = document.querySelector(".question");
const answers = document.querySelector(".answers");
const spnQtd = document.querySelector(".spnQtd");
const textFinish = document.querySelector(".finish span");
const content = document.querySelector(".content");
const contentFinish = document.querySelector(".finish");
const btnRestart = document.querySelector(".finish button");

import questions from "./questions.js";

let currentIndex = 0;
let questionsCorrect = 0;

btnRestart.onclick = () => {
  content.style.display = "flex";
  contentFinish.style.display = "none";

  currentIndex = 0;
  questionsCorrect = 0;
  loadQuestion();
};

function nextQuestion(e) {
  if (e.target.getAttribute("data-correct") === "true") {
    questionsCorrect++;
  }

  if (currentIndex < questions.length - 1) {
    currentIndex++;
    loadQuestion();
  } else {
    finish();
  }
}

function finish() {
  textFinish.innerHTML = `você acertou ${questionsCorrect} de ${questions.length}`;
  content.style.display = "none";
  contentFinish.style.display = "flex";
}

function loadQuestion() {
  spnQtd.innerHTML = `${currentIndex + 1}/${questions.length}`;
  const item = questions[currentIndex];
  answers.innerHTML = "";
  question.innerHTML = item.question;

  item.answers.forEach((answer) => {
    const div = document.createElement("div");

    div.innerHTML = `
    <button class="answer" data-correct="${answer.correct}">
      ${answer.option}
    </button>
    `;

    answers.appendChild(div);
  });

  document.querySelectorAll(".answer").forEach((item) => {
    item.addEventListener("click", nextQuestion);
  });
}
var currentQuestion = 0;
    var score = 0;

    function loadQuestion() {
      var questionElement = document.getElementById("question");
      var optionAElement = document.getElementById("optionA");
      var optionBElement = document.getElementById("optionB");
      var optionCElement = document.getElementById("optionC");
      var optionDElement = document.getElementById("optionD");

      var current = questions[currentQuestion];
      questionElement.textContent = current.question;
      optionAElement.textContent = current.options.A;
      optionBElement.textContent = current.options.B;
      optionCElement.textContent = current.options.C;
      optionDElement.textContent = current.options.D;
    }

    function nextQuestion() {
      var selectedAnswer = document.querySelector('input[name="answer"]:checked');

      if (selectedAnswer) {
        if (selectedAnswer.value === questions[currentQuestion].answer) {
          score++;
        }

        currentQuestion++;

        if (currentQuestion < questions.length) {
          loadQuestion();
        } else {
          showResult();
        }

        // Limpar seleção da resposta
        selectedAnswer.checked = false;
      } else {
        alert("Por favor, selecione uma resposta!");
      }
    }

    function showResult() {
      var resultContainer = document.getElementById("result-container");
      var scoreElement = document.getElementById("score");
      var totalQuestions = questions.length;

      resultContainer.style.display = "block";
      scoreElement.textContent = "Você acertou " + score + " de " + totalQuestions + " perguntas.";
    }

    // Iniciar o jogo
    loadQuestion();

loadQuestion();
