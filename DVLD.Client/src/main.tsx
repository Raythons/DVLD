import ReactDOM from 'react-dom/client'
import App from './App.tsx'
import "./css/normalize.css"
import { Provider } from 'react-redux'
import { persistor , store } from './redux/store.ts'
import { PersistGate } from 'redux-persist/integration/react';
import "./index.css"
import "./css/App.css"

ReactDOM.createRoot(document.getElementById('root')!).render(
  <Provider  store = {store}>
      <PersistGate loading={null} persistor={persistor}>
          <App />
      </PersistGate>
  </Provider>
)
