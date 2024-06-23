// eslint-disable-next-line no-undef, @typescript-eslint/no-var-requires
const flowbite = require("flowbite-react/tailwind");

/** @type {import('tailwindcss').Config} */
export default {
  content: [
    "./index.html",
    "./src/**/*.{js,ts,jsx,tsx}",
    // "node_modules/flowbite-react/lib/esm/**/*.js",
    flowbite.content(),
  ],
  theme: {
    extend: {
      minWidth: {
        "80p": "80%",
      },
      spacing: {
        "243px": "243px",
        "300px": "300px",
        "350px": "350px",
        "400px": "400px",
        "450px": "450px",
        "500px": "500px",
        "550px": "550px",
      },
    },
  },
  // eslint-disable-next-line no-undef
  plugins: [flowbite.plugin()],
};
