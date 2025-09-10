let felicidad = 50;

function actualizar() {
  const estadoText =
    felicidad <= 20 ? 'hambrienta 🤤' :
    felicidad <= 40 ? 'aburrida 😴' :
    'contenta 🥳';
  document.getElementById('estado').textContent =
    `Tu mascota está ${estadoText} (felicidad: ${felicidad})`;
}

document.getElementById('btnJugar').addEventListener('click', () => {
  felicidad = Math.min(100, felicidad + 10);
  actualizar();
});

document.getElementById('btnComer').addEventListener('click', () => {
  felicidad = Math.min(100, felicidad + 8);
  actualizar();
});

document.getElementById('btnIgnorar').addEventListener('click', () => {
  felicidad = Math.max(0, felicidad - 12);
  actualizar();
});

actualizar();