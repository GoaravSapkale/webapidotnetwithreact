import logo from './logo.svg';
import './App.css';
import DisplayStudent from './component/DisplayStudent';
import InsertStudent from './component/InsertStudent';
import DeleteStudent from './component/DeleteStudent';
function App() {
  return (
    <>
    <DisplayStudent></DisplayStudent>
    <InsertStudent></InsertStudent>
    <DeleteStudent></DeleteStudent>
    </>
  );
}

export default App;
