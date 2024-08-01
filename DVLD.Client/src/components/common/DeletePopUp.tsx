import {  } from '@reduxjs/toolkit/query'
import { Button, Modal, ModalBody, Spinner } from 'flowbite-react'
import React, {  useState } from 'react'
import { ApiError } from '../../redux/api/peopleApi'
import CustomError from './CustomError'
import SuccessPopUp from './SuccessPopUp'
import { isApiError } from '../../redux/helpers'

type deletePopUpProps = {
    show:boolean
    type: string
    deletionId: number
    setShowPopUp: React.Dispatch<React.SetStateAction<boolean>>,
    isLoading: boolean,
    isError: boolean,
    error: ApiError,
    mutation: (id: number) => Promise<unknown>
}

const DeletePopUp = ({show, type, deletionId, isLoading, isError, error, setShowPopUp, mutation} : deletePopUpProps) => {

    const handleDeletion = async (deletionId : number) => {
        const result = await  mutation(deletionId)
        if(!isApiError(result))
            setShowSuccessPopUp(!showSuccessPopUp);

        setShowResultPopUp(!showResultPopUp)
    }
    
    console.log("Render Values");
    
    
    const [showResultPopUp, setShowResultPopUp] = useState<boolean>(false)
    const [showSuccessPopUp, setShowSuccessPopUp] = useState<boolean>(false)
    
    return (
        <Modal show={show} onClose={() => setShowPopUp(!show)} >
            <Modal.Header />
                <ModalBody  className='flex justify-center items-center flex-col' >
                    {
                        isLoading ?   <Spinner className='' size="lg"/> 
                        :
                        <div className="flex justify-center items-center flex-col w-[100%]">
                            <h1 className="text-rose-500 text-2xl">Warning</h1>
                            <p className="text-lg text-gray-700 pb-3"> Do You Want To Delete {type} With of Id: {deletionId}</p>
                            <div className="flex  justify-between items-center w-[90%]">
                                <Button color="blue" className="" onClick={() => setShowPopUp(!show)}>cancel</Button>
                                <Button disabled = {isError}  color="failure" onClick={() => handleDeletion(deletionId)} >Delete</Button>
                            </div>
                        </div>
                    }
                    { isError && !isLoading
                        ?  
                            <CustomError error={error ? error as ApiError : error} />
                        :
                            <SuccessPopUp 
                            show={showSuccessPopUp}
                            creationId={deletionId}
                            type={type}
                            setShowPopUp={setShowSuccessPopUp}  operation='Deleted' />
                    }
                </ModalBody>
        </Modal>
    )
}

export default DeletePopUp